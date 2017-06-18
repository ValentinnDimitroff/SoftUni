using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.Little_John
{
    public class LittleJohn
    {
        private const int CountCycles = 4;
        public static void Main()
        {
            int countSmall = 0, countMedium = 0, countLarge = 0;
            string patternSmall = ">----->", patternMedium = ">>----->", patternLarge = ">>>----->>";

            for (int i = 0; i < CountCycles; i++)
            {
                var input = Console.ReadLine();

                countLarge += Regex.Matches(input, patternLarge).Count;
                input = Regex.Replace(input, patternLarge, " ");

                countMedium += Regex.Matches(input, patternMedium).Count;
                input = Regex.Replace(input, patternMedium, " ");

                countSmall += Regex.Matches(input, patternSmall).Count;
            }

            int number = countLarge + countMedium * 10 + countSmall * 100;
            var binReg = Convert.ToString(number, 2);
            var binRev = new string(binReg.ToCharArray().Reverse().ToArray());
            Console.WriteLine(Convert.ToInt32(binReg+binRev, 2));
        }
    }
}
