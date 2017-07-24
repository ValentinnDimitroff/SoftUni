namespace _05.Comparing_Objects
{
    using System;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town) 
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Town { get; private set; }

        public int CompareTo(Person person)
        {
            int result;
            if ((result = this.Name.CompareTo(person.Name)) != 0)
            {
                return result;
            }

            if ((result = this.Age.CompareTo(person.Age)) != 0)
            {
                return result;
            }

            return this.Town.CompareTo(person.Town);
        }
    }
}
