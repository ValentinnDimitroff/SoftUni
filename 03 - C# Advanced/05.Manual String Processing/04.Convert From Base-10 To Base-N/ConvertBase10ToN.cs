using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04.Convert_From_Base_10_To_Base_N
{
    public class ConvertBase10ToN
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();
                
            var baseN = input[0];
            var number = input[1];

            var result = new StringBuilder();
            while (number > 0)
            {
                var digit = number % baseN;
                result.Insert(0, digit);
                number /= baseN;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
