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
        ///     Processes the specified option with the passed argument values.
        /// </summary>
        /// <param name="optionName">The name of the option specified in the CLI.</param>
        /// <param name="args">Any argument values that are specified for the cammand that is issued.</param>
        /// <returns>
        ///     Returns a success flag indicating if the operation was
        ///     successful or not.
        /// </returns>
        bool ProcessOption(string optionName, string[] args);
        void Default();
        void PrintHelp();
        void PrintHelp(string subCommand);
    }
}
