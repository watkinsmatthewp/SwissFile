using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissFile.Console
{
    public class Arg
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool RequireValue { get; set; }
        public List<string> ExampleValues { get; set; }

        public Arg(string key, string name)
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
