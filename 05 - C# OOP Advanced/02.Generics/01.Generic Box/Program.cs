namespace _01.Generic_Box
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var numberOfStrings = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStrings; i++)
            {
                var currentString = Console.ReadLine();
                Console.WriteLine(new Box<string>(currentString));
            }
        }
    }
}
