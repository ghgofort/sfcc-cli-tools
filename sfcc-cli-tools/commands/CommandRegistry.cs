using System;
using sfcc_cli_tools.commands;
using sfcc_cli_tools.Interfaces;
namespace sfcc_cli_tools.commands
{
    public class CommandRegistry
    {
        /// <summary>
        /// Lists all available command verbs for the sftools cli command. Any
        /// new features added as a new command verb should be added to the
        /// array. This should be replaced with something less manual if there
        /// is a good way known to do this.
        /// </summary>
        private readonly string[] REGISTERED_COMMANDS = {
            "help",
            "sync"
        };

        public CommandRegistry()
        {

        }

        public ICommandClass GetCommandClass(String commandVerb)
        {
            switch (commandVerb)
            {
                case "sync":
                    return new Sync();
                case "help":
                default:
                    return new Help();
            }
        }
    }
}
