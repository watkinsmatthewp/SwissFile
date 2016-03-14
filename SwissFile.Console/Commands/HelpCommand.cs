using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Console
{
    public class HelpCommand : Command
    {
        public HelpCommand() : base("help")
        {

        }
        
        protected override void ExecuteInternal(Dictionary<string, string> args)
        {
            foreach (Command cmd in Commands.AllComamnds.Values.Where(c => !(c is HelpCommand)))
            {
                SysOut.Print("----------------------------");
                SysOut.Print("NAME: {0}", cmd.Name);
                SysOut.Print("DESCRIPTION: {0}", cmd.Description);
                if (cmd.RequiredArgKeys.Count > 0)
                {
                    SysOut.Print("REQUIRED ARGUMENTS:");
                    foreach (Arg arg in cmd.RequiredArgKeys)
                    {
                        SysOut.Print("- {0} ({1})", arg.Name, arg.Key);
                        SysOut.Print("  {0}", arg.Description);
                        
                    }
                }


                SysOut.Print("----------------------------");
            }
        }
    }
}

