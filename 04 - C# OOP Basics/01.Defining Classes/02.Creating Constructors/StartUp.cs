namespace CreatingConstructors
{
    using System;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            ConstructorInfo ageCtor = personType.GetConstructor(new Type[] {typeof(int)});
            ConstructorInfo nameAgeCtor = personType.GetConstructor(new Type[] {typeof(string), typeof(int)});

            var swapped = false;
            if (nameAgeCtor == null)
            {
                nameAgeCtor = personType.GetConstructor(new Type[] {typeof(int), typeof(string)});
                swapped = true;
            }

            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var basePerson = (Person) emptyCtor.Invoke(new object[] { });
            var personWithAge = (Person) ageCtor.Invoke(new object[] {age});
            var personWithAgeAndName = swapped
                ? (Person) nameAgeCtor.Invoke(new object[] {age, name})
                : (Person) nameAgeCtor.Invoke(new object[] {name, age});

            Console.WriteLine($"{basePerson.name} {basePerson.age}");
            Console.WriteLine($"{personWithAge.name} {personWithAge.age}");
            Console.WriteLine($"{personWithAgeAndName.name} {personWithAgeAndName.age}");
        }
    }
}

