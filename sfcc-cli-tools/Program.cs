using System;

namespace sfcc_cli_tools
{
    class Program
    {
        static void Main(string[] args)
        {
            String strArgPrefix = "";
            String strArgValue = "";

            // Check for CLI arguments passed.
            if (args.Length != 0)
            {
                // Loop through the command line args.
                for(int x = 0; x < args.Length; x++)
                {
                    // If the arg starts with a hyphen then it is a flag
                    if (args[x].IndexOf('-') == 0)
                    {
                        // Get the character(s) for the flag:
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
