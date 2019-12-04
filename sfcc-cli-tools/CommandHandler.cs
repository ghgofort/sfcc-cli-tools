using System;
using System.Collections.Generic;
using sfcc_cli_tools.Interfaces;
using sfcc_cli_tools.commands;
namespace sfcc_cli_tools
{
    /// <summary>
    ///     A class that is initialized once for each `sftools` command
    ///     executed. This class acts as a wrapper for the underlying
    ///     `ICommandClass` instance and is used to handle parsing the
    ///     passed command, command-options, and command-option values.
    /// </summary>
    public class CommandHandler
    {
        /// <summary>
        ///     This method is responsible for mapping of all of the command
        ///     names to the maatching command handler class. This is a quick,
        ///     dirty veraion that should be replaced with a more elegant DI
        ///     solution at some point.
        /// </summary>
        /// <param name="commandName"></param>
        /// <returns>ICommandClass</returns>
        private ICommandClass FindCommand(String commandName) {
            return cmdRegistry.GetCommandClass(commandName);
        }

        private readonly CommandRegistry cmdRegistry = new CommandRegistry();

        /// <summary>
        ///     Constructor method that handles the passed in arguments.
        /// </summary>
        /// <param name="args"></param>
        public CommandHandler(string[] args)
        {
            string[] options;
            string strCommand;
            ICommandClass cmdInstance;

            // Check for CLI arguments passed.
            if (args.Length != 0)
            {
                strCommand = args[0];
                cmdInstance = FindCommand(strCommand);

                if (args.Length > 1)
                {
                    // Get the number of command options to initialize the array.
                    int i = 0;
                    while (i < args.Length && args[i].IndexOf('-') == 0)
                    {
                        i++;
                    }

                    // Initialize the array with the arg values.
                    options = new string[i];
                    for (int j = 0; j < i; j++)
                    {
                        if (args[j].Substring(1).IndexOf('-') == -1)
                        {
                            string strOption = args[j].Substring(1);
                            options[j] = strOption;
                        }
                    }
                } else
                {
                    Console.Write(cmdInstance.GetHelp());
                }
            } else
            {
                // If no command was passed call the "help" command by default.
                cmdInstance = FindCommand("help");
                Console.Write(cmdInstance.GetHelp());
            }
        }
    }
}
