using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Core
{
    public abstract class FileTaskResult
    {
        public DateTime Finished { get; set; }
        public Exception Exception { get; set; }
    }
}
