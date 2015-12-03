using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Core
{
    public class SplitFileTask : FileTask<SplitFileTaskResult>
    {
        private long _totalBytesReadFromInputFile = 0;
        private long _totalInputFileByteSize = 0;
        
        // Output file variables
        private int _filePieceID = -1;
        private string _currentOutputFilePath = null;
        private FileStream _currentOutputFileStream = null;
        private long _bytesWrittenToCurrentOutputFile = 0;
        
        public FileInfo InputFile { get; private set; }
        public DirectoryInfo DestinationDirectory { get; private set; }

        public long MaxOutputFileByteSize { get; set; }
        public bool PreserveTextLines { get; set; }
        public string FileExtension { get; set; }

        public SplitFileTask(FileInfo inputFile, DirectoryInfo destinationDirectory)
        {
            // Defaults: 1 MB chunks, don't treat as text
            MaxOutputFileByteSize = 1000000;
            PreserveTextLines = false;
            
            inputFile.EnsureNotNull("input file");
            inputFile.EnsureExists();
            InputFile = inputFile;

            FileExtension = InputFile.Extension;
            _totalInputFileByteSize = InputFile.Length;

            destinationDirectory.EnsureNotNull("destination directory");
            if (destinationDirectory.Exists)
            {
                destinationDirectory.Delete(true);
            }
            destinationDirectory.Create();
            DestinationDirectory = destinationDirectory;
        }
        
        protected override SplitFileTaskResult ExecuteInternal()
        {
            SplitFileTaskResult result = new SplitFileTaskResult();
            Run(result, () =>
            {
                if (PreserveTextLines)
                {
                    SplitText(result);
                }
                else
                {
                    SplitBytes(result);
                }
            });
            return result;
        }

        private void SplitText(SplitFileTaskResult result)
        {
            using (FileStream fs = InputFile.OpenRead())
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        // Read the next line
                        byte[] bytes = reader.CurrentEncoding.GetBytes(reader.ReadLine());
                        _totalBytesReadFromInputFile += bytes.Length;
                        Progress = _totalBytesReadFromInputFile / _totalInputFileByteSize;
                        OnProgressUpdated();

                        if (_bytesWrittenToCurrentOutputFile > 0 && _bytesWrittenToCurrentOutputFile + bytes.Length > MaxOutputFileByteSize)
                        {
                            // This line would put the current file over the limit
                            FlushCurrentOutputStreamToFile(result);
                        }

                        // Write the line
                        WriteToCurrentOutputStream(bytes);
                        if (reader.EndOfStream)
                        {
                            // Last piece
                            FlushCurrentOutputStreamToFile(result);
                        }
                    }
                }
            }
        }

        private void SplitBytes(SplitFileTaskResult result)
        {
            int maxBytesToReadEachLoop = (int)Math.Min(1000000, MaxOutputFileByteSize);

            using (FileStream fs = InputFile.OpenRead())
            {
                while (_totalBytesReadFromInputFile < _totalInputFileByteSize)
                {
                    long bytesLeftInThisOutputFile = MaxOutputFileByteSize - _bytesWrittenToCurrentOutputFile;
                    if (bytesLeftInThisOutputFile == 0)
                    {
                        FlushCurrentOutputStreamToFile(result);
                    }
                    
                    // Determine how many bytes to read/write
                    int bytesToReadWrite = (int)Math.Min(bytesLeftInThisOutputFile, maxBytesToReadEachLoop);

                    // Read the chunk of bytes
                    byte[] bytes = new byte[bytesToReadWrite];
                    int bytesRead = fs.Read(bytes, (int)_totalBytesReadFromInputFile, bytesToReadWrite);
                    _totalBytesReadFromInputFile += bytes.Length;
                    Progress = _totalBytesReadFromInputFile / _totalInputFileByteSize;
                    OnProgressUpdated();
                    
                    if (bytesRead != bytesToReadWrite)
                    {
                        throw new ArgumentException(bytesRead + " were read but we expected " + bytesToReadWrite);
                    }

                    // Process that chunk
                    WriteToCurrentOutputStream(bytes);
                    _bytesWrittenToCurrentOutputFile += bytesToReadWrite;
                    _totalBytesReadFromInputFile += bytesToReadWrite;

                    if (_totalBytesReadFromInputFile >= _totalInputFileByteSize)
                    {
                        // Last piece
                        FlushCurrentOutputStreamToFile(result);
                    }
                }
            }
        }

        private void WriteToCurrentOutputStream(byte[] bytes)
        {
            if (_currentOutputFileStream == null)
            {
                // Setup for another write
                _bytesWrittenToCurrentOutputFile = 0;
                _currentOutputFilePath = GetNextFilePath();
                _currentOutputFileStream = new FileStream(_currentOutputFilePath, FileMode.Append);
            }

            // Write the bytes
            _currentOutputFileStream.Write(bytes, 0, bytes.Length);
            _bytesWrittenToCurrentOutputFile += bytes.Length;
        }

        private void FlushCurrentOutputStreamToFile(SplitFileTaskResult result)
        {
            if (_currentOutputFileStream != null)
            {                
                // Close out the current stream
                _currentOutputFileStream.Close();
                _currentOutputFileStream = null;

                // Add the output file name to the result
                result.SplitFiles.Add(new FileInfo(_currentOutputFilePath));
            }
        }

        private string GetNextFilePath()
        {
            string fileName = (++_filePieceID).ToString("0000") + (String.IsNullOrWhiteSpace(FileExtension) ? FileExtension : "");
            return Path.Combine(DestinationDirectory.FullName, fileName);
        }
    }
}
