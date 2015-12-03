using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Console
{
    internal static class CommandParser
    {
        private static readonly Command[] ALL_COMMANDS = new Command[]
        {
            new SplitFileCommand()
        };
        
        internal static Command Parse(string[] cmdPieces)
        {
            if (cmdPieces == null || cmdPieces.Length == 0)
            {
                throw new ArgumentException("Cannot parse and empty command");
            }

            Command command = ALL_COMMANDS.FirstOrDefault(c => cmdPieces[0].Equals(c.Name, StringComparison.OrdinalIgnoreCase));
            if (command == null)
            {
                throw new Exception("There is no " + cmdPieces[0] + " command");
            }

            return command;
        }
    }
}
