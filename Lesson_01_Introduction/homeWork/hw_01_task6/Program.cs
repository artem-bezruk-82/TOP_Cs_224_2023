//Модуль 1
//Задание 6
//Пользователь вводит с клавиатуры показания температуры.
//В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий или наоборот.

namespace hw_01_task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to our temperature converter!");

            while (ConsoleInputHandling.EndProgram("Start new calculation?"))
            {
                Console.WriteLine("\nPlease chose temperature scale");

                switch (TempScalesEnumExt.GetEnumItemConsole())
                {
                    case TempScalesEnum.Celsius:
                        Console.WriteLine($"Please enter temperature value in {TempScalesEnum.Celsius}");
                        try
                        {
                            double celsiusValue = ConsoleInputHandling.GetConsoleInputRange(-273, 6000);
                            Console.WriteLine($"{celsiusValue} {TempScalesEnum.Celsius} =" +
                                $" {9 / 5 * (celsiusValue + 32)} {TempScalesEnum.Fahrenheit}");
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine(exc.Message);
                        }
                        break;
                    case TempScalesEnum.Fahrenheit:
                        Console.WriteLine($"Please enter temperature value in {TempScalesEnum.Fahrenheit}");
                        try
                        {
                            double fahrenheitValue = ConsoleInputHandling.GetConsoleInputRange(-459, 10000);
                            Console.WriteLine($"{fahrenheitValue} {TempScalesEnum.Fahrenheit} =" +
                                $" {5 / 9 * (fahrenheitValue - 32)} {TempScalesEnum.Celsius}");
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine(exc.Message);
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("\nThank you for using our calculator! Goodbye!");
        }
    }
}