//Модуль 1
//Задание 3
//Пользователь вводит с клавиатуры четыре цифры. 
//Необходимо создать число, содержащее эти цифры.
//Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578.


namespace hw_01_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Our program receives 4 digits from user via console and returns 4-digints number");

            while (EndProgram("Would you like to start program?"))
            {
                string numberStr = string.Empty;

                while (numberStr.Length < 4)
                {
                    Console.WriteLine($"\nPlease enter digit #{numberStr.Length + 1} ");
                    char digitChar = Console.ReadKey().KeyChar;
                    numberStr += digitChar;
                }

                try
                {
                    int number = Convert.ToInt32(numberStr);
                    Console.WriteLine($"\nThe number is {number}");
                }
                catch (Exception exc)
                {
                    Console.WriteLine($"\n{exc.Message}");
                }
            }
            Console.WriteLine("\nThank you for using our program! Goodby");
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