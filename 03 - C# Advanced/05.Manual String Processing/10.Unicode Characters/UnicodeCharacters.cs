using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Unicode_Characters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();

            var result = new StringBuilder();
            foreach (var letter in inputText)
            {
                result.Append(@"\u" + $"{(int)letter:x4}");
            }

            Console.WriteLine(result.ToString()); 
        }
    }
}
