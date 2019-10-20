using System;

namespace sfcc_cli_tools
{
    class Program
    {
        static void Main(string[] args)
        {
            String strArgPrefix = "";
            String strArgValue = "";
            CommandHandler commandHandler = new CommandHandler();

            // Check for CLI arguments passed.
            if (args.Length != 0)
            {
                // Loop through the command line args.
                for(int x = 0; x < args.Length; x++)
                {
                    // Command arguments will not have a hyphen, modifiers will.
                    if (args[x].IndexOf('-') == -1)
                    {

                    } else { 
                        // Check if the 2nd char is also a hyphen or if this is
                        // the short version.
                        if (args[x].Substring(1, 1).IndexOf('-') == 0)
                        {
                            // Get the CLI flag portion of the argument.
                            strArgPrefix = args[x].Substring(2, args[x].Length - 1);
                        }
                        else
                        {
                            // Get the CLI flag portion of the argument.
                            strArgPrefix = args[x].Substring(1, args[x].Length - 1);
                        }
                        // The next arg will be the associated value.
                        strArgValue = args[x + 1];
                    }
                }
            }
            Console.WriteLine("Hello World! Args: " + strArgPrefix + " " + strArgValue);
        }
    }
}
