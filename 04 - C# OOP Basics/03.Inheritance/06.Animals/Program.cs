namespace Animals
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string animalType;
            while ((animalType = Console.ReadLine()) != "Beast!")
            {

                try
                {
                    var animalInfo = Console.ReadLine().Split(' ');
                    switch (animalType)
                    {
                        case "Cat":
                            var cat = new Cat(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(cat);
                            break;
                        case "Dog":
                            var dog = new Dog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(dog);
                            break;
                        case "Frog":
                            var frog = new Frog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(frog);
                            break;
                        case "Kitten":
                            var kitten = new Kitten(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(kitten);
                            break;
                        case "Tomcat":
                            var tomcat = new Tomcat(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(tomcat);
                            break;
                        default:
                            throw new InvalidInputException();
                    }
                }
                catch (InvalidInputException iie)
                {
                    Console.WriteLine(iie.Message);
                }
            }
        }
    }
}
