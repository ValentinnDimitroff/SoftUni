using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student_Results
{
    class StudentResults
    {
        static void Main(string[] args)
        {
           var n = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average"));

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] {' ', ',', '-'}, StringSplitOptions.RemoveEmptyEntries);

                var name = tokens[0];
                var firstNum = decimal.Parse(tokens[1]);
                var secondNum = decimal.Parse(tokens[2]);
                var thirdNum = decimal.Parse(tokens[3]);
                var average = (firstNum + secondNum + thirdNum) / 3;

                Console.WriteLine(string.Format("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|", name, firstNum, secondNum, thirdNum, average));
            }
        }
    }
}
