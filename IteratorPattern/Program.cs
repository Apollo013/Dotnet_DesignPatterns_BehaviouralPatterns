using IteratorPattern.Aggregates;
using IteratorPattern.Iterators;
using IteratorPattern.Models;
using IteratorPattern.RealWorld;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection people = new Collection();
            people[0] = new Person("Mary");
            people[1] = new Person("Jane");
            people[2] = new Person("John");
            people[3] = new Person("Doe");
            people[4] = new Person("Peter");

            // Iterator
            IIterator<Person> iterator = people.CreateIterator();

            // Iterate
            for (Person person = iterator.First(); !iterator.IsDone; person = iterator.Next())
            {
                System.Console.WriteLine($"{person.Name}");
            }

            System.Console.WriteLine();
            RunRealWorlExample();
        }

        private static void RunRealWorlExample()
        {
            People people = new People();
            people[0] = new Person("Mary");
            people[1] = new Person("Jane");
            people[2] = new Person("John");
            people[3] = new Person("Doe");
            people[4] = new Person("Peter");

            while (people.MoveNext())
            {
                var person = people.Current;
                System.Console.WriteLine(person.Name);
            }
        }
    }
}
