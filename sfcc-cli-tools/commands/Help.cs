using System;
using sfcc_cli_tools.Interfaces;
namespace sfcc_cli_tools.commands
{
    public class Help : ICommandClass
    {
        public static String commandName = "help";
        public static String commandShort = "-h";
        public static char[] allowedModifiers = new char['h'];

        /// <summary>
        ///     Prints the help instructions for general sfcc-cli-tools use to
        ///     the users console.
        /// </summary>
        public void PrintHelp() 
        {
            Console.WriteLine("usage: sftools help or sftools -h");
        }

        public void PrintHelp(string subCommand)
        {
            if (subCommand == "-h" || subCommand == "--help")
            {
                PrintHelp();
            }
        }

        /// <summary>
        ///     ICommandClass interface method for invoking the default command
        ///     execution when if options are passed. For most commands this
        ///     calls the PrintHelp() function.
        /// </summary>
        public void Default()
        {
            PrintHelp();
        }


        public bool ProcessOption(string optionName, string[] arguments)
        {
            return false;
        }
    }
}
