using System;
using System.Collections.Generic;
using sfcc_cli_tools.Interfaces;
using sfcc_cli_tools.commands;
namespace sfcc_cli_tools
{
    public class CommandHandler
    {
        private Dictionary<string, ICommandClass> dictCommands = new Dictionary<string, ICommandClass>();

        public CommandHandler(string[] args)
        {
            String strArgPrefix = "";
            String strArgValue = "";
            String strCommand = "";

            // Check for CLI arguments passed.
            if (args.Length != 0)
            {
                // First arg is the command name.
                strCommand = args[0];

                if (args.Length > 1)
                {
                    // Loop through the command args & modifiers.
                    for (int x = 1; x < args.Length; x++)
                    {
                        // Command arguments will not have a hyphen, modifiers &
                        // flags will.
                        if (args[x].IndexOf('-') == -1)
                        {
                            strCommand = args[x];
                        }
                        else
                        {
                            // Check if the 2nd char is also a hyphen or if this is
                            // the short version.
                            if (args[x].Substring(1, 1).IndexOf('-') == 0)
                            {
                                // Get the CLI flag portion of the modifier.
                                strArgPrefix = args[x].Substring(2, args[x].Length - 1);
                            }
                            else
                            {
                                // Get the CLI flag portion of the modifier.
                                strArgPrefix = args[x].Substring(1, args[x].Length - 1);
                            }
                            // The next arg will be the associated value.
                            strArgValue = args[x + 1];
                        }
                    }
                }
            }
            Console.WriteLine("Hello World! Args: " + strArgPrefix + " " + strArgValue);
        }
    }
}
