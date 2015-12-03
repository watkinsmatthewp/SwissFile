using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Core
{
    public class SplitFileTaskResult : FileTaskResult
    {
        public List<FileInfo> SplitFiles { get; private set; }

        public SplitFileTaskResult()
        {
            SplitFiles = new List<FileInfo>();
        }
    }
}
