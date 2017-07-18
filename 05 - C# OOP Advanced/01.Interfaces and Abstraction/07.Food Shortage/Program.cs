namespace _07.Food_Shortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var buyers = new Dictionary<string, IBuyer>();
            var numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                if (tokens.Length == 3)
                {
                    buyers.Add(tokens[0], new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
                else
                {
                    buyers.Add(tokens[0], new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }
            }

            string buyer;
            while ((buyer = Console.ReadLine()) != "End")
            {
                if (buyers.ContainsKey(buyer))
                {
                    buyers[buyer].BuyFood();
                }
            }

            Console.WriteLine(buyers.Sum(b => b.Value.Food));
        }
    }
}
