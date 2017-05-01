using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.VowelsSum
{
     public class VowelsSum
    {
        public static void Main()
        {
            Dictionary<char, int> vowels = new Dictionary<char, int>();
            vowels.Add('a', 1);
            vowels.Add('e', 2);
            vowels.Add('i', 3);
            vowels.Add('o', 4);
            vowels.Add('u', 5);

            string inText = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i <= inText.Length - 1; i++)
            {
                if (vowels.ContainsKey(inText[i]))
                {
                    sum += vowels[inText[i]];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
