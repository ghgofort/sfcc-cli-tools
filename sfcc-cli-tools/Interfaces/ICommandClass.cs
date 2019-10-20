using System;
namespace sfcc_cli_tools.Interfaces
{
    public interface ICommandClass
    {
        String getCommandName();
        String getCommandShort();
        String getSyntax();
        String getDescription();
        String getExample();
        char[] getAllowedModifiers();
    }
}
