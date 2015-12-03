using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                Run(args);
            }
            else
            {
                while (true)
                {
                    string line = Cmd.ReadLine().Trim();
                    if (line.Equals("q") || line.Equals("quit") || line.Equals("exit") )
                    {
                        break;
                    }

                    Run(line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                }
            }
        }

        private static void Run(string[] cmdPieces)
        {
            Command command = CommandParser.Parse(cmdPieces);

            Dictionary<string, string> args = new Dictionary<string, string>();
            for (int i = 1; i < cmdPieces.Length; i++)
            {
                string cmdPiece = cmdPieces[i];
                string key = cmdPiece;
                string value = null;

                int equalsIndex = cmdPiece.IndexOf('=');
                if (equalsIndex > 0)
                {
                    key = cmdPiece.Substring(0, equalsIndex);
                    value = cmdPiece.Substring(equalsIndex + 1);
                }

                args[key] = value;
            }

            command.Execute(args);
        }
    }
}
