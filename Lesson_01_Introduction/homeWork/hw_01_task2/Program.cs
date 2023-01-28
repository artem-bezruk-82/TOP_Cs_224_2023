//Модуль 1
//Задание 2
//Пользователь вводит с клавиатуры два числа.
//Первое число — это значение, второе число процент, который необходимо посчитать.
//Например, мы ввели с клавиатуры 90 и 10. Требуется вывести на экран 10 процентов от 90. Результат: 9.


namespace hw_01_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Our program calculates persentage.");

            while (EndProgram("\nWould you like new colculation?"))
            {
                try
                {
                    Console.WriteLine("\nPlease enter base value");
                    double baseValue = double.Parse(Console.ReadLine() ?? string.Empty);
                    Console.WriteLine("Please enter persentage value");
                    double persentage = double.Parse(Console.ReadLine() ?? string.Empty);
                    double result = GetPersentageOperation(baseValue, persentage);
                    Console.WriteLine($"{persentage}% of {baseValue} is {result}");
                }
                catch (Exception exc)
                {

                    Console.WriteLine(exc.Message);
                }
            }

            Console.WriteLine("\nThank you for using uor program! Goodby!");

        }

        static double GetPersentageOperation(double value, double percentage) 
        {
            if (percentage < 0 || percentage > 100) 
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(percentage), 
                    message: $"{nameof(percentage)} is out of 0..100 range");
            }
            return (percentage * value) / 100;
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