using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissFile.Core;

namespace SwissFile.Console
{
    internal abstract class Command
    {
        internal string Name { get; private set; }
        internal string Description { get; set; }
        internal List<Arg> RequiredArgKeys { get; set; }
        internal List<Arg> OptionalArgKeys { get; set; }

        protected Command(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Cannot have a null or white space command name");
            }
            Name = name;
            RequiredArgKeys = new List<Arg>();
            OptionalArgKeys = new List<Arg>();
        }

        internal void Execute(Dictionary<string, string> args)
        {
            try
            {
                if (args.Any(a => a.Key.Equals("help", StringComparison.OrdinalIgnoreCase) || a.Key.Equals("?", StringComparison.OrdinalIgnoreCase)))
                {
                    ShowCommandHelp();
                }
                else
                {
                    ParseAndExecuteCommand(args);
                }
            }
            catch(Exception e)
            {
                Cmd.Print("Error: {0}. Type {1} ? to show this command's help", e.ToString(), Name);
            }
        }

        private void ShowCommandHelp()
        {
            Cmd.Print("------ BEGIN {0} COMMAND HELP ------", Name.ToUpperInvariant());
            Cmd.Print("Description: " + (String.IsNullOrWhiteSpace(Description) ? "This command has no description" : Description));
            Cmd.Print("Required arguments:");
            foreach (Arg arg in RequiredArgKeys)
            {
                Cmd.Print("- {0} ({1})", arg.Name, arg.Key);
                if (!String.IsNullOrWhiteSpace(arg.Description))
                {
                    Cmd.Print("  {0}", arg.Description);
                }
                Cmd.Print("  A value is {0}required for this argument key", (arg.RequireValue ? "" : "not "));
                if (arg.ExampleValues != null && arg.ExampleValues.Count > 0)
                {
                    Cmd.Print("  Example values:");
                    foreach (string exanpleValue in arg.ExampleValues)
                    {
                        Cmd.Print("  - {0}", exanpleValue);
                    }
                }
            }
            Cmd.Print("------ END {0} COMMAND HELP ------", Name.ToUpperInvariant());
        }

        private void ParseAndExecuteCommand(Dictionary<string, string> args)
        {
            Dictionary<string, string> sanitizedArgs = new Dictionary<string, string>();

            // Get args in correct format
            IEnumerable<Arg> allAvailableArgKeys = RequiredArgKeys.Union(OptionalArgKeys);
            foreach (KeyValuePair<string, string> arg in args)
            {
                Arg argKey = allAvailableArgKeys.FirstOrDefault(a => arg.Key.Equals(a.Key, StringComparison.OrdinalIgnoreCase));
                if (argKey != null)
                {
                    sanitizedArgs[argKey.Key] = arg.Value;
                }
            }

            // make sure all required args have been provided
            foreach (Arg requiredArg in RequiredArgKeys)
            {
                if (!sanitizedArgs.ContainsKey(requiredArg.Key))
                {
                    throw new Exception("The {0} arg must be specified for this command.");
                }
            }

            ExecuteInternal(sanitizedArgs);
        }

        protected abstract void ExecuteInternal(Dictionary<string, string> args);

        protected string GetArg(Dictionary<string, string> args, Arg arg)
        {
            if (!ContainsArg(args, arg))
            {
                return null;
            }
            return args[arg.Key];
        }

        protected bool ContainsArg(Dictionary<string, string> args, Arg arg)
        {
            return args.ContainsKey(arg.Key);
        }
    }
}
