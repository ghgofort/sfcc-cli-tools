using System;
namespace sfcc_cli_tools.Interfaces
{
    /// <summary>
    ///     An interface that defines the common methods of all sfcc-cli-tools
    ///     commands.
    /// </summary>
    public interface ICommandClass
    {
        /// <summary>
        ///     Prints the commands help information.
        /// </summary>
        /// <param name="optionName">
        ///     The value entered by the user for the command option/
        /// </param>
        /// <returns></returns>
        bool IsValidOption(string optionName);
        bool ProcessOption(string optionName);
        void Default();
        void PrintHelp();
    }
}
