using System;
using System.Reflection;

namespace DefinePerson
{
    public class StartUp
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            ////Bonus Part
            //var firstPerson = new Person("Pesho", 20);
            //var secondPerson = new Person("Gosho", 18);
            //var thirdPerson = new Person("Stamat", 43);

            //Console.WriteLine(firstPerson.name + " " + firstPerson.age);
            //Console.WriteLine(secondPerson.name + " " + secondPerson.age);
            //Console.WriteLine(thirdPerson.name + " " + thirdPerson.age);
        }
    }
}
