//Модуль 1
//Задание 1
//Пользователь вводит с клавиатуры число в диапазоне от 1 до 100.
//Если число кратно 3 (делится на 3 без остатка) нужно вывести слово Fizz.
//Если число кратно 5 нужно вывести слово Buzz.
//Если число кратно 3 и 5 нужно вывести Fizz Buzz.
//Если число не кратно не 3 и 5 нужно вывести само число.
//Если пользователь ввел значение не в диапазоне от 1 до 100 требуется вывести сообщение об ошибке.


namespace hw_01_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome to our program!");

            while (EndProgram("Would you like new calculation?"))
            {
                try
                {
                    byte value = GetUserInputConsole(1, 100);
                    Console.WriteLine(GetOutputStr(value));
                }
                catch (Exception exc)
                {

                    Console.WriteLine(exc.Message);
                }
            }

            Console.WriteLine("\nThank you for using our program! Goodbye!");
        }

        static string GetOutputStr(byte input)
        {
            string outputStr = $"{input}";

            if (input % 3 == 0)
            {
                outputStr = "Fizz";
            }

            if (input % 5 == 0)
            {
                if (outputStr == $"{input}")
                {
                    outputStr = "Bizz";
                }
                else
                {
                    outputStr += " Bizz";
                };
            }
            return outputStr;
        }

        static byte GetUserInputConsole(byte startRange, byte endRange)
        {
            byte userInputConsole;
            Console.WriteLine($"\nPlease enter {typeof(byte)} value within {startRange}...{endRange} range");
            if (!byte.TryParse(Console.ReadLine(), out userInputConsole))
            {
                throw new FormatException(message:$"Invalid format. Entered value should be {typeof(byte)} type");
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