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

        public char[] getAllowedModifiers()
        {
            throw new NotImplementedException();
        }

        public string getCommandName()
        {
            return Sync.commandName;
        }

        public string getCommandShort()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Gets the command description text to print for the user.
        /// </summary>
        /// <returns>string</returns>
        public string getDescription()
        {
            string strDescription = "usage: ";
            strDescription += "sftools sync: A tool for syncing files from the local file system to your Salesforce Commerce Cloud sandbox.";
            return strDescription;
        }

        public string getExample()
        {
            throw new NotImplementedException();
        }

        public string getSyntax()
        {
            throw new NotImplementedException();
        }
    }
}
