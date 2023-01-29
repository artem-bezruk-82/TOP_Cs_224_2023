//Модуль 1
//Задание 5
//Пользователь вводит с клавиатуры дату.
//Приложение должно отобразить название сезона и дня недели. 
//Например, если введено 22.12.2021, приложение должно отобразить Winter Wednesday.

namespace hw_01_task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter date, using DD.MM.YYYY format");

            DateOnly date = DateOnly.Parse(Console.ReadLine() ?? string.Empty);

            string season = date.Month switch
            {
                >= 3 and < 6 => "Spring",
                >= 6 and < 9 => "Summer",
                >= 9 and < 12 => "Autumn",
                12 or (>= 1 and < 3) => "Winter",
                _ => throw new ArgumentOutOfRangeException(nameof(date), $"Date with unexpected month: {date.Month}.")
            };

            Console.WriteLine($"{date} {date.DayOfWeek} {season}");
        }
    }
}