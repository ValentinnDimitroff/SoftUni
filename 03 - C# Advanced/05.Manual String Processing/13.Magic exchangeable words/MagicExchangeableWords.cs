using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Magic_exchangeable_words
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var inputWords = Console.ReadLine()
                .Split(' ');
            var longerWord = inputWords[0].Length < inputWords[1].Length ? inputWords[0] : inputWords[1];
            var shorterWord = inputWords[0].Length >= inputWords[1].Length ? inputWords[0] : inputWords[1];

            if (longerWord.Distinct().Count() != shorterWord.Distinct().Count())
            {
                Console.WriteLine("false");
                return;
            }

            var mappedChars = new Dictionary<char, char>();
           
            for (int i = 0; i < longerWord.Length; i++)
            {
                if (!mappedChars.ContainsKey(shorterWord[i]))
                {
                    mappedChars.Add(shorterWord[i], longerWord[i]);
                }
                else if (mappedChars[shorterWord[i]] != longerWord[i])
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            
            for (int i = longerWord.Length; i < shorterWord.Length; i++)
            {
                if (!mappedChars.ContainsKey(shorterWord[i]))
                {
                    Console.WriteLine("false");
                    return;
                }
            }
           
            Console.WriteLine("true");
        }
    }
}
