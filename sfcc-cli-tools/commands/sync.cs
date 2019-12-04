using System;
using sfcc_cli_tools.Interfaces;
namespace sfcc_cli_tools.commands
{
    /// <summary>
    ///     A command class for handling the syncing of code between the
    ///     local environment file system and the sandbox file system using the
    ///     WebDav protocol.
    /// </summary>
    public class Sync : ICommandClass
    {
        public static String commandName = "sync";
        public Sync()
        {
            Console.WriteLine("sync command called...");
        }

        public void Default()
        {
            throw new NotImplementedException();
        }

        public bool IsValidOption(string optionName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Gets the command description text to print for the user.
        /// </summary>
        /// <returns>string</returns>
        public void PrintHelp()
        {
            Console.WriteLine("usage: ");
            Console.WriteLine("sftools sync: A tool for syncing files from the local file system to your Salesforce Commerce Cloud sandbox.");
        }

        public bool ProcessOption(string optionName)
        {
            throw new NotImplementedException();
        }
    }
}
