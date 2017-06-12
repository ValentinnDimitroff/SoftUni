using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Applied_Arithmetics
{
    public static class AppliedArithmetics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = numbers.ForEach(n => n + 1);
                        break;
                    case "multiply":
                        numbers = numbers.ForEach(n => n * 2);
                        break;
                    case "subtract":
                        numbers = numbers.ForEach(n => n - 1);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }

                command = Console.ReadLine();
            }

           // Console.WriteLine(string.Join(" ", numbers));
        }

        public static List<T> ForEach<T>(this List<T> numbers, Func<T,T> operation )
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                numbers[i] = operation(numbers[i]);
            }

            return numbers;
        }
    }

    

    
}
