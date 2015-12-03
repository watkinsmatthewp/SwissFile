using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissFile.Core;

namespace SwissFile.Console
{
    class SplitFileCommand : Command
    {
        // Args specific to this command
        private static readonly Arg PRESERVE_TEXT_LINES = new Arg("pres-text-lines", "Preserve Text Lines")
        {
            Description = "Supply this argument if you want to preserve text lines and not split them across files",
            RequireValue = false
        };
        
        public SplitFileCommand() : base("split-file")
        {
            RequiredArgKeys = new List<Arg>() { CommonArgs.SRC_FILE, CommonArgs.DEST_DIR };
            OptionalArgKeys = new List<Arg>() { CommonArgs.ENC, PRESERVE_TEXT_LINES };
        }

        protected override void ExecuteInternal(Dictionary<string, string> args)
        {
            string srcFile = GetArg(args, CommonArgs.SRC_FILE);
            string destDir = GetArg(args, CommonArgs.DEST_DIR);
            SplitFileTask task = new SplitFileTask(new FileInfo(srcFile), new DirectoryInfo(destDir))
            {
                PreserveTextLines = ContainsArg(args, PRESERVE_TEXT_LINES)
            };
            task.Execute();
        }
    }
}
