using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Special_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var specialWords = Console.ReadLine().Split();
            var dict  = new Dictionary<string, int>();
            foreach (var specialWord in specialWords)
            {
                dict.Add(specialWord, 0);   
            }
            var inputText = Console.ReadLine().Split(new []{ '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in inputText)
            {
                if (dict.ContainsKey(s))
                {
                    dict[s]++;
                }
            }

            foreach (var i in dict)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
            }
        }
    }
}
