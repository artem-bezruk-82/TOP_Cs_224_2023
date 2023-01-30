using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_01_task6
{
    public static class ConsoleInputHandling
    {
        public static int GetConsoleInputInt()
        {
            int userInputInt = -1;

            while (!int.TryParse(Console.ReadLine(), out userInputInt))
            {
                Console.WriteLine("You have entered not a number. Please try again");
            }

            return userInputInt;
        }

        public static double GetConsoleInputDouble()
        {
            double userInputInt = -1;

            while (!double.TryParse(Console.ReadLine(), out userInputInt))
            {
                Console.WriteLine("You have entered not a number. Please try again");
            }

            return userInputInt;
        }

        public static double GetConsoleInputRange(double startRange, double endRange)
        {
            double userInputConsole;
            Console.WriteLine($"\nPlease enter {typeof(double)} value within {startRange}...{endRange} range");

            if (!double.TryParse(Console.ReadLine(), out userInputConsole))
            {
                throw new FormatException(message: $"Invalid format. Entered value should be {typeof(double)} type");
            }
            if (userInputConsole < startRange || userInputConsole > endRange)
            {
                throw new ArgumentOutOfRangeException($"Entered via console value",
                    $"Value is out of {startRange}...{endRange} range");
            }
            return userInputConsole;
        }

        public static bool EndProgram(string requestText)
        {
            Console.WriteLine($"\n{requestText}, Yes(y), No(n)");
            char key = Console.ReadKey().KeyChar;
            while (key != 'n' && key != 'y')
            {
                Console.WriteLine("\nThe only 'y' or 'n' are required");
                key = Console.ReadKey().KeyChar;
            }
            if (key == 'y')
            {
                return true;
            }
            return false;
        }
    }
}
