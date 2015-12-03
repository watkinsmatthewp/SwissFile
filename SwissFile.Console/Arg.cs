using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Console
{
    internal class Arg
    {
        internal string Key { get; set; }
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal bool RequireValue { get; set; }
        internal List<string> ExampleValues { get; set; }

        internal Arg(string key, string name)
        {
            if (String.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentException("Arg key cannot be null or empty");
            }
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Arg name cannot be null or empty");
            }
            Key = key;
            Name = name;
            ExampleValues = new List<string>();
        }
    }
}
