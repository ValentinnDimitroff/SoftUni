using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TriFunction
{
    public class TriFunction
    {
        public static void Main()
        {
            var charSum = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(' ');

            Func<string, int, bool> checkSum = (str, sum) =>
            {
                int localSum = 0;
                foreach (var element in str)
                {
                    localSum += element;
                }
                return localSum >= sum;
            } ;

            var result = FindFirstMatch(names, charSum, checkSum);

            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
            }
        }

        private static string FindFirstMatch(string[] names, int charSum, Func<string, int, bool> checkSum)
        {
            foreach (var name in names)
            {
                if (checkSum(name, charSum))
                {
                    return name;
                }    
            }

            return null;
        }
    }
}
