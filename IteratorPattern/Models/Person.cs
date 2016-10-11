namespace IteratorPattern.Models
{
    public class Person
    {
        public string Name { get; private set; }
        public string SSN { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, string ssn)
        {
            Name = name;
            SSN = ssn;
        }
    }
}
