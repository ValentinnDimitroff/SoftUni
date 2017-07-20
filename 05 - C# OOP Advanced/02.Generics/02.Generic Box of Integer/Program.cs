namespace _02.Generic_Box_of_Integer
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var numberOfStrings = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStrings; i++)
            {
                var currentString = int.Parse(Console.ReadLine());
                Console.WriteLine(new Box<int>(currentString));
            }
        }
    }
}
