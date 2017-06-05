using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var inputWords = Console.ReadLine()
                .Split(new []{' ', '.', ',', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new SortedSet<string>();

            foreach (var word in inputWords)
            {
                var isPalindrome = true;

                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (!word[i].Equals(word[word.Length - i - 1]))
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine("[" + string.Join(", ", palindromes) + "]");
        }
    }
}
