using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Console
{
    internal static class CommonArgs
    {
        internal static readonly Arg SRC_FILE = new Arg("src-file", "Source File")
        {
            Description = "The fully qualified path of the source file for this command",
            ExampleValues = new List<string>() { "C:\\my-input-file.txt" },
            RequireValue = true
        };

        internal static readonly Arg DEST_FILE = new Arg("dest-file", "Destination File")
        {
            Description = "The fully qualified path of the destination file for this command",
            ExampleValues = new List<string>() { "C:\\my-output-file.txt" },
            RequireValue = true
        };

        internal static readonly Arg DEST_DIR = new Arg("dest-dir", "Destination Directory")
        {
            Description = "The fully qualified path of the destination directory for this command",
            ExampleValues = new List<string>() { "C:\\my-output-directory" },
            RequireValue = true
        };

        internal static readonly Arg REPLACE_EXISTING = new Arg("replace-existing", "Replace Existing")
        {
            Description = "Whether or not to replace the destination if it already exists",
            RequireValue = false
        };

        internal static readonly Arg ENC = new Arg("enc", "Encoding")
        {
            Description = "The encoding to use for this command",
            ExampleValues = new List<string>() { "UTF8" },
            RequireValue = true
        };
    }
}
