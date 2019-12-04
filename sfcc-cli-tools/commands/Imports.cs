using System;
using sfcc_cli_tools.Interfaces;

namespace sfcc_cli_tools.commands
{
    /// <summary>
    ///     A command class for managing the list of changes from the default
    ///     site data in order to get a consistent environment when built to any
    ///     new sandbox or PIG environment.
    /// </summary>
    public class Imports : ICommandClass
    {
        public Imports()
        {
            Console.WriteLine();
            Console.WriteLine("    -- command syntax:");
            Console.WriteLine("      -- sftools imports [options] [[--] <additional arguments>]");
            Console.WriteLine("");
            Console.WriteLine("    -- options:");
            Console.WriteLine("    ");
        }

        public char[] getAllowedModifiers()
        {
            throw new NotImplementedException();
        }

        public string getCommandName()
        {
            throw new NotImplementedException();
        }

        public string getCommandShort()
        {
            throw new NotImplementedException();
        }

        public string getDescription()
        {
            string strDescription = "sftools imports: A tool for managing an ordered list of changes to system schema using SFCC standard import/export files in order to easily replicate all necessary SFCC setup on any SFCC instance.";
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
