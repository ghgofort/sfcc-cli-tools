using System;
using System.Collections.Generic;
using sfcc_cli_tools.Interfaces;

namespace sfcc_cli_tools
{
    public class CommandHandler
    {

        private Dictionary<string, ICommandClass> dictCommands = new Dictionary<string, ICommandClass>();
        // The commands to be executed. This array acts as a FIFO queue.
        private String[] commandStack;
        public CommandHandler(String[] commandNames)
        {
            var intCommandCount = commandNames.Length;
            if (commandNames.Length > 0)
            {
                for (int x = 0; x < intCommandCount; x++)
                {

                }
            }
        }


    }
}
