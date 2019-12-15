using System;
using sfcc_cli_tools.Interfaces;

namespace sfcc_cli_tools.commands
{
    /// <summary>
    ///     A command class for managing the list of changes from the default
    ///     site data in order to get a consistent environment when built to any
    ///     new sandbox or PIG environment.
    /// </summary>
    public class Impex : ICommandClass
    {
        /// <summary>
        ///     Creates the directory structure in the local file system for a
        ///     new set of import/export files to be applied as a set.
        /// </summary>
        /// <param name="name">
        ///     The name of the new record, also used to name the subdirectory
        ///     the impex records are created in.
        /// </param>
        /// <param name="options"></param>
        /// <returns></returns>
        private bool CreateImpexRecord(string name, string[] options)
        {
            return false;
        }

        /// <summary>
        ///     Finds the local impex directory at the specified relative path,
        ///     and returns a bool indicating if a migrations directory was
        ///     found in a recursive lookup from the specified path and child
        ///     directories.
        /// </summary>
        /// <param name="relativePath"></param>
        /// <returns></returns>
        private bool FindImpexDirectory(string relativePath)
        {
            return false;
        }

        /// <summary>
        ///     Constructor method for class.
        /// </summary>
        public Impex()
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
            PrintHelp();
        }

        /// <summary>
        ///     Prints usage, option, and argument specification information for
        ///     the command to the console for the user.
        /// </summary>
        /// <returns></returns>
        public void PrintHelp()
        {
            Console.WriteLine("sftools impex:");
            Console.WriteLine("  -- Description: A tool for managing an ordered list of changes to system schema using SFCC standard import/export files in order to easily replicate all necessary SFCC setup on any SFCC instance."); 
        }

        /// <summary>
        ///     TODO: Implement ProcessOption for Imports class.
        /// </summary>
        /// <param name="optionName"></param>
        /// <returns>Returns a flag indicating the success./returns>
        public bool ProcessOption(string optionName)
        {
            switch(optionName)
            {
                case "new":
                    /// TODO: Process new option of impex command.
                    break;
                case "run":
                    /// TODO: Process run option of impex command.
                    break;
                default:
                    break;
            }
            return false;
        }
    }
}
