using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissFile.Core;

namespace SwissFile.Console
{
    public class CopyFileCommand : Command
    {
        public CopyFileCommand() : base("copy-file")
        {
            RequiredArgKeys = new List<Arg>() { CommonArgs.SRC_FILE, CommonArgs.DEST_FILE };
            OptionalArgKeys = new List<Arg>() { CommonArgs.REPLACE_EXISTING };
        }

        protected override void ExecuteInternal(Dictionary<string, string> args)
        {
            string srcFile = GetArg(args, CommonArgs.SRC_FILE);
            string destFile = GetArg(args, CommonArgs.DEST_FILE);
            CopyFileTask task = new CopyFileTask(new FileInfo(srcFile), new FileInfo(destFile))
            {
                OverwriteDestinationFile = ContainsArg(args, CommonArgs.REPLACE_EXISTING)
            };
            task.Execute();
        }
    }
}
