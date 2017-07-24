namespace _04.Froggy
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var stones = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var lake = new Lake(stones);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
