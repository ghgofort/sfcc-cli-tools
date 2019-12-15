using System;
namespace sfcc_cli_tools.Interfaces
{
    /// <summary>
    ///     An interface that defines the common methods of all sfcc-cli-tools
    ///     commands.
    /// </summary>
    public interface ICommandClass
    {
        /// <param name="optionName"></param>
        /// <returns>
        ///     Returns a success flag indicating if the operation was
        ///     successful or not.
        /// </returns>
        bool ProcessOption(string optionName, string[] arguments);
        void Default();
        void PrintHelp();
    }
}
