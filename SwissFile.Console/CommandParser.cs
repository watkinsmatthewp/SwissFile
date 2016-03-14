using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Console
{
    internal static class CommandParser
    {        
        internal static Command Parse(string[] cmdPieces)
        {
            if (cmdPieces == null || cmdPieces.Length == 0)
            {
                throw new ArgumentException("Cannot parse and empty command");
            }

            string cmdName = cmdPieces[0].Trim().ToLowerInvariant();
            if (!Commands.AllComamnds.ContainsKey(cmdName))
            {
                throw new Exception("There is no \"" + cmdName + "\" command");
            }

            return Commands.AllComamnds[cmdName];
        }
    }
}
