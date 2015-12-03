using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Console
{
    internal static class Cmd
    {
        internal static void Print(string fmt, params object[] args)
        {
            System.Console.WriteLine(args == null ? fmt : String.Format(fmt, args));
        }

        internal static string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }
}
