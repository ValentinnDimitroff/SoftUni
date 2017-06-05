using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05.Convert_From_Base_N_To_Base_10
{
    public class ConvertBaseNTo10
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var baseN = int.Parse(input[0]);
            var number = input[1];

            BigInteger result = 0;
            BigInteger basePowered = 1;
            for (int i = number.ToString().Length - 1; i >= 0; i--)
            {
                result += BigInteger.Multiply(int.Parse(number[i].ToString()), basePowered);
                basePowered *= baseN;
            }
            
            Console.WriteLine(result);
        }
    }
}
