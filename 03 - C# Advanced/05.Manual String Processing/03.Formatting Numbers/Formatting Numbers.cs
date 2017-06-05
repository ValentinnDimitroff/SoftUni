using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Formatting_Numbers
{
    public class FormattingNumbers
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(new []{' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            var intNum = int.Parse(inputNumbers[0]);
            var firstFloatNum = double.Parse(inputNumbers[1]);
            var secondFloatNum = double.Parse(inputNumbers[2]);

            var firstColumn = intNum.ToString("X").PadRight(10, ' ');
            var secondColumn = Convert.ToString(intNum, 2).PadLeft(10, '0').Substring(0, 10);
            //var thirdColumn = firstFloatNum.ToString("F2").PadLeft(10, ' ');
            //var fourthColumn = secondFloatNum.ToString("F3").PadRight(10, ' ');

            Console.WriteLine($"|{firstColumn,10}|{secondColumn}|{firstFloatNum,10:f2}|{secondFloatNum,-10:f3}|");
        }
    }
}
