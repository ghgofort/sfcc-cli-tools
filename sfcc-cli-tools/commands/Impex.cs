using System;
using System.IO;
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
        /// <param name="options"></param>
        /// <returns></returns>
        private bool CreateImpexRecord(string[] options)
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
        private string FindImpexDirectory(string relativePath)
        {
            // Directory names to look for to find the impex register.
            string[] IMPEX_DIR_NAMES =
            {
                "/migrations",
                "/impex"
            };

            // Matching tracking file names.
            string [] IMPEX_TRACKING_FILES =
            {
                "migrations.xml",
                "impex.xml"
            }
            string impexPath = "";
            if (Directory.Exists(relativePath)) {
                // Loop through the allowed directory names, and check if any
                // exist in the current checkDirectory.
                for (int i = 0; i < IMPEX_DIR_NAMES.Length; i++)
                {
                    string checkPath = relativePath + IMPEX_DIR_NAMES[i];
                    if (Directory.Exists(checkPath))
                    {
                        impexPath = checkPath;
                    }
                }
            }
            return impexPath;
        }

        /// <summary>
        ///     Constructor method for class.
        /// </summary>
        public Impex()
        {
            PrintHelp();
        }

        /// <summary>
        ///     Prints Help information for the command by calling PrintHelp.
        ///     This method is invoked if the command is called without any
        ///     options or arguments spedified.
        /// </summary>
        public void Default()
        {
            PrintHelp("-h");
        }

        /// <summary>
        ///     Prints usage, option, and argument specification information for
        ///     the command to the console for the user.
        /// </summary>
        /// <param name="commandName">The name of the SFCC command.</param>
        /// <returns></returns>
        public void PrintHelp(string commandName)
        {
            string strCommandLower = commandName.ToLower();
            if (strCommandLower == "-h" || strCommandLower == "--help" || strCommandLower == "")
            {
                PrintHelp();
            }
            else if (strCommandLower == "new")
            {

            }
            
        }

        /// <summary>
        ///     TODO: Implement ProcessOption for Imports class.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="args">An array of arguments passed for the sync CLI command execution.</param>
        /// <returns>Returns a flag indicating the success./returns>
        public bool ProcessOption(string optionName, string[] args)
        {
            // Get the current directory.
            string path = Directory.GetCurrentDirectory();
            bool success = false;
            if (args.Length > 0 && args[0] != "-h" && args[0] != "--help")
            {   

                PrintHelp("new");
                switch(optionName)
                {
                    case "new":
                        // --source OR -s :: source directory of new IMPEX record.
                        if (Array.IndexOf(args, "--source") > -1 || Array.IndexOf(args, "-s") > -1)
                        {

                        }
                        success = CreateImpexRecord(args);
                        break;
                    case "run":
                        /// TODO: Process sftools impex run
                        break;
                    case "set":
                        
                        break;
                    default:
                        break;
                }
            }
            else
            {
                PrintHelp(optionName);
            }
            return success;
        }

        public void PrintHelp()
        {
            Console.WriteLine("Usage: sftools impex [options] [[--] <additional arguments>]");
            Console.WriteLine("");
            Console.WriteLine("    -- options:");
            Console.WriteLine("        - new:    ");
            Console.WriteLine("        - run:    ");
            Console.WriteLine("        - meta:    ");
            Console.WriteLine("        - type:    ");
        }
    }
}
