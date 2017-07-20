namespace _11.Threeuple
{
    using System;
    using System.Security.Policy;

    public class Program
    {
        public static void Main()
        {
            var firstPair = Console.ReadLine().Split(' ');
            var name = $"{firstPair[0]} {firstPair[1]}";
            var address = firstPair[2];
            var town = firstPair[3];
            var firstThreeuple = new Threeuple<string, string, string>(name, address, town);

            var secondPair = Console.ReadLine().Split(' ');
            name = secondPair[0];
            var beerAmount = int.Parse(secondPair[1]);
            var isDrunk = secondPair[2] == "drunk" ? true : false;
            var secondThreeuple = new Threeuple<string, int, bool>(name, beerAmount, isDrunk);

            var thirdPair = Console.ReadLine().Split(' ');
            name = thirdPair[0];
            var doubleItem = double.Parse(thirdPair[1]);
            var bankName = thirdPair[2];
            var thirdThreeuple = new Threeuple<string, double, string>(name, doubleItem, bankName);

            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
