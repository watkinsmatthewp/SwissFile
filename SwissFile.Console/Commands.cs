using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Console
{
    public static class Commands
    {
        private static readonly Command[] _allCommands = new Command[]
        {
            new SplitFileCommand(),
            new CopyFileCommand()
        };

        public static readonly Dictionary<string, Command> AllComamnds = _allCommands.ToDictionary(c => c.Name, c => c);
    }
}
