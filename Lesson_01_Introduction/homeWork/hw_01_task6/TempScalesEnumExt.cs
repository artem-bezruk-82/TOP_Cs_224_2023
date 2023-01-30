using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_01_task6
{
    public static class TempScalesEnumExt
    {
        public static void ShowEnum()
        {
            var types = Enum.GetValues(typeof(TempScalesEnum));
            foreach (var type in types)
            {
                Console.WriteLine($"\t{(int)type} - {type}");
            }
        }

        public static TempScalesEnum GetEnumItemConsole()
        {
            ShowEnum();
            int value = ConsoleInputHandling.GetConsoleInputInt();
            while (!Enum.IsDefined(typeof(TempScalesEnum), value))
            {
                Console.WriteLine("Value is not defined. Please try again");
                value = ConsoleInputHandling.GetConsoleInputInt();
            }

            return (TempScalesEnum)value;
        }
    }
}
