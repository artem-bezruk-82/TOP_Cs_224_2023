using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetirementCalculator
{
    public static class PersonExt
    {
        public static void PrintRetirementInfoConsole(this Person person)
        {
            if (person.GetAgeGroup() == Person.AgeGroupsEnum.retired)
            {
                Console.WriteLine($"{person.Name} has already been retired since {person.RetirementDate}");
            }
            else 
            {
                Console.WriteLine($"{person.Name} is going to be retired starting {person.RetirementDate}");
            }
        }
    }
}
