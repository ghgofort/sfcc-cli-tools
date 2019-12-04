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

        /// <summary>
        ///     Prints Help information for the command by calling PrintHelp.
        ///     This method is invoked if the command is called without any
        ///     options or arguments spedified.
        /// </summary>
        public void Default()
        {

        }

        /// <summary>
        ///     Checks if the passed string is a valid identifier for one of the
        ///     command options.
        /// </summary>
        /// <param name="optionName"></param>
        /// <returns></returns>
        public Boolean IsValidOption(string optionName)
        {
            return false;
        }

        /// <summary>
        ///     Prints usage, option, and argument specification information for
        ///     the command to the console for the user.
        /// </summary>
        /// <returns></returns>
        public void PrintHelp()
        {
            Console.WriteLine("sftools imports: A tool for managing an ordered list of changes to system schema using SFCC standard import/export files in order to easily replicate all necessary SFCC setup on any SFCC instance.");
        }

        /// <summary>
        ///     TODO: Implement ProcessOption for Imports class.
        /// </summary>
        /// <param name="optionName"></param>
        /// <returns></returns>
        public bool ProcessOption(string optionName)
        {
            return false;
        }
    }
}
