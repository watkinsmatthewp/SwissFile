using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Core
{
    public class CopyFileTask : FileTask<CopyFileTaskResult>
    {
        public FileInfo SourceFile { get; private set; }
        public FileInfo DestinationFile { get; private set; }

        public bool OverwriteDestinationFile { get; set; }
        public bool DeleteSourceFileAfterCopy { get; set; }

        public CopyFileTask(FileInfo sourceFile, FileInfo destinationFile)
            : base()
        {
            sourceFile.EnsureNotNull("Source file");
            sourceFile.EnsureExists();
            SourceFile = sourceFile;

            destinationFile.EnsureNotNull("Destination file");
            DestinationFile = destinationFile;
        }
        
        protected override CopyFileTaskResult ExecuteInternal()
        {
            if (!OverwriteDestinationFile && DestinationFile.Exists)
            {
                throw new ArgumentException("Not configured to overwrite the destination file");
            }

            SourceFile.CopyTo(DestinationFile.FullName, OverwriteDestinationFile);
            if (DeleteSourceFileAfterCopy)
            {
                SourceFile.Delete();
            }
            return new CopyFileTaskResult();
        }
    }
}
