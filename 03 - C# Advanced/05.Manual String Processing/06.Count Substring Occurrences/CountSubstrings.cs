using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Count_Substring_Occurrences
{
    public class CountSubstrings
    {
        public static void Main()
        {
            var inputStr = Console.ReadLine();
            var substirng = Console.ReadLine();

            int index = 0, counter = 0;
            while ((index = inputStr.IndexOf(substirng, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                index++;
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
