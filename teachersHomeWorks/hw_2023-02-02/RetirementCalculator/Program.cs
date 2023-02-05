namespace RetirementCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person misha = new Person(name: "Misha Petrov", new DateOnly(1982, 10, 12), Person.GendersEnum.Man);
            Person zina = new Person(name: "Zina Sidorova", new DateOnly(1960, 01, 16), Person.GendersEnum.Woman);

            List<Person> persons = new List<Person>() 
            {
                misha,
                zina,
            };

            Console.WriteLine("\nRetirement information: ");
            foreach (Person personItem in persons)
            {
                personItem.PrintRetirementInfoConsole();
            }

            Console.WriteLine("\nPerson information: ");
            foreach (Person personItem in persons)
            {
                Console.WriteLine(personItem);
            }
        }

    }

}