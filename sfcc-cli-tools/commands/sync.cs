using System;
using sfcc_cli_tools.Interfaces;
namespace sfcc_cli_tools.commands
{
    public class Sync : ICommandClass
    {
        public static String commandName = "sync";
        public Sync()
        {
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
