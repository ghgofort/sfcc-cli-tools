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

        /// <summary>
        ///     ICommandClass interface method for checking if a specified
        ///     option name exists for the command.
        /// </summary>
        /// <param name="optionName">The name passed by the user.</param>
        /// <returns>Returns true if the option name exists</returns>
        public bool IsValidOption(string optionName)
        {
            Boolean isValid = false;

            return isValid;
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


        public bool ProcessOption(string optionName)
        {
            throw new NotImplementedException();
        }
    }
}
