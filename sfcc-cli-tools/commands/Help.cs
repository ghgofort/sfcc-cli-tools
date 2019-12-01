using System;
using sfcc_cli_tools.Interfaces;
namespace sfcc_cli_tools.commands
{
    public class Help : ICommandClass
    {
        public static String commandName = "help";
        public static String commandShort = "-h";
        public static char[] allowedModifiers = new char['h'];

        public Help() 
        {
            Console.WriteLine("sftools --help: Gives information on the available commands and syntax used for sftools cli.");
        }

        public char[] getAllowedModifiers()
        {
            return Help.allowedModifiers;
        }

        public string getCommandName()
        {
            return Help.commandName;
        }

        public string getCommandShort()
        {
            return Help.commandShort;
        }

        public string getDescription()
        {
            throw new NotImplementedException();
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
