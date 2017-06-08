using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Letter_Change_Numbers
{
    public class LetterChangeNumbers
    {
        public static void Main()
        {
            var inputGroups = Console.ReadLine()
                .Split(new []{' ', '\t', '\n'},StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;
            foreach (var group in inputGroups)
            {
                var firstLetter = char.Parse(group.Substring(0, 1));
                var number = int.Parse(group.Substring(1, group.Length - 2));
                var lastLetter = char.Parse(group.Substring(group.Length - 1, 1));

                double sum = number;
                if (char.IsUpper(firstLetter))
                {
                    sum /= firstLetter - 'A' + 1;
                }
                else
                {
                    sum *= firstLetter - 'a' + 1;
                }

                if (char.IsUpper(lastLetter))
                {
                    sum -= lastLetter - 'A' + 1;
                }
                else
                {
                    sum += lastLetter - 'a' + 1;
                }

                totalSum += sum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
