//Модуль 1
//Задание 7
//Пользователь вводит с клавиатуры два числа.
//Нужно показать все четные числа в указанном диапазоне.
//Если границы диапазона указаны неправильно требуется произвести нормализацию границ.
//Например, пользователь ввел 20 и 11, требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.

namespace hw_01_task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter start range value");
            int rangeStart = int.Parse(Console.ReadLine() ?? String.Empty);
            Console.WriteLine("Please enter end range value");
            int rangeEnd = int.Parse(Console.ReadLine() ?? String.Empty);

            if (rangeStart > rangeEnd)
            {
                (rangeStart, rangeEnd) = (rangeEnd, rangeStart);
            }

            for (int i = rangeStart; i <= rangeEnd; i++)
            {
                if ((i % 2 == 0) && (i != 0)) 
                {
                    Console.Write($" {i}");
                }
            }
        }
    }
}