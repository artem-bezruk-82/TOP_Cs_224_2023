//Модуль 1
//Задание 4
//Пользователь вводит шестизначное число. После чего пользователь вводит номера разрядов для обмена цифр. 
//Например, если пользователь ввёл один и шесть — это значит, что надо обменять местами первую и шестую цифры.
//Число 723895 должно превратиться в 523897.
//Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке

using System.Text;

namespace hw_01_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, our program allows to swap 2 digits within 6-digits number");
            while (EndProgram("\nWould you like to start program?"))
            {
                Console.WriteLine("\nPlease enter 6-digits number");
                StringBuilder sixDigitsNumberStr = new StringBuilder(Console.ReadLine());
                try
                {
                    int sixDigitsnumber = Convert.ToInt32(sixDigitsNumberStr.ToString());
                    if (sixDigitsNumberStr.Length == 6)
                    {
                        int firstPosition = GetUserInputConsole(0, sixDigitsNumberStr.Length);
                        int secondPosition = GetUserInputConsole(0, sixDigitsNumberStr.Length);
                        (sixDigitsNumberStr[firstPosition], sixDigitsNumberStr[secondPosition])
                            = (sixDigitsNumberStr[secondPosition], sixDigitsNumberStr[firstPosition]);
                        Console.WriteLine(sixDigitsNumberStr);
                    }
                    else
                    {
                        Console.WriteLine("Error: The number you are etrering must contain 6 digits");
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }

            Console.WriteLine("Thank you for using our program. Goodbye!");
        }


        static int GetUserInputConsole(int startRange, int endRange)
        {
            int userInputConsole;
            Console.WriteLine($"\nPlease enter {typeof(int)} value within {startRange}...{endRange} range");
            if (!int.TryParse(Console.ReadLine(), out userInputConsole))
            {
                throw new FormatException(message: $"Invalid format. Entered value should be {typeof(int)} type");
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