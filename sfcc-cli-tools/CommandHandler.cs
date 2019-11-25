using System;
using System.Collections.Generic;
using sfcc_cli_tools.Interfaces;
using sfcc_cli_tools.commands;
namespace sfcc_cli_tools
{
    public class CommandHandler
    {
        /// <summary>
        /// This method is responsible for mapping of all of the command names
        /// to the maatching command handler class. This is a quick and dirty
        /// veraionthat should be replaced with a more elegant DI solution at
        /// some point.
        /// </summary>
        /// <param name="commandName"></param>
        /// <returns></returns>
        private ICommandClass findCommand(String commandName)
        {
            // Handle all registered commands here.
            if (commandName == "help")
            {
                return new Help();
            }
            return null;
        }


        public CommandHandler(string[] args)
        {
            String strArgPrefix = "";
            String strArgValue = "";
            String strCommand = "";

            // Check for CLI arguments passed.
            if (args.Length != 0)
            {
                strCommand = args[0];
                Console.WriteLine("Passed Command: " + args[0]);

                var cmdInstance = findCommand(strCommand);

                if (args.Length > 1)
                {    
                    // Loop through the command args & modifiers.
                    for (int x = 1; x < args.Length; x++)
                    {
                        Console.WriteLine("Arg " + x + ": " + args[x]);
                        // Command arguments will not have a hyphen, modifiers &
                        // flags will.
                        if (args[x].IndexOf('-') == -1)
                        {
                            Console.WriteLine("Command Arg: " + args[x]);
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
