using System;
using System.Collections.Generic;
using System.Text;

namespace GTC.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    public static class GetInput
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="consoleMessage"></param>
        /// <returns></returns>
        public static int GetNumericFromConsole(string consoleMessage)
        {
            Console.WriteLine(consoleMessage);
            string input = Console.ReadLine();
            int x;
            if (Int32.TryParse(input, out x) == false)
            {
                Console.WriteLine("Value was not in the form of an integer. Please try again.");
                return GetNumericFromConsole(consoleMessage);
            }
            else
            {
                return x;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consoleMessage"></param>
        /// <returns></returns>
        public static string GetConsoleLine(string consoleMessage)
        {
            Console.WriteLine($"{consoleMessage}:");
            string input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consoleMessage"></param>
        /// <returns></returns>
        public static int GetConsoleLineAsInteger(string consoleMessage)
        {
            Console.WriteLine($"{consoleMessage}:");
            string input = Console.ReadLine();
            int x;
            if (Int32.TryParse(input, out x))
                return x;
            Console.WriteLine("Input not a valid number. Please try again.");
            return (GetConsoleLineAsInteger(consoleMessage));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consoleMessage"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string GetConsoleLineWithDefaults(string consoleMessage, string defaultValue)
        {
            Console.WriteLine($"{consoleMessage}: {defaultValue}");
            Console.WriteLine("To keep this, press ENTER. To change, enter a new value and press ENTER");
            string input = Console.ReadLine();
            if (input != "")
                return input;
            else
                return defaultValue;
        }
    }
}
