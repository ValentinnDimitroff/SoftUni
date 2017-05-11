using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSymbols
{
    public class Program
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();
            var symbols = new SortedDictionary<char, int>();
            foreach (var symbol in inputText)
            {
                if (symbols.ContainsKey(symbol))
                {
                    symbols[symbol] += 1;
                }
                else
                {
                    symbols[symbol] = 1;
                }
            }

            foreach (var element in symbols)
            {
                Console.WriteLine($"{element.Key}: {element.Value} time/s");
            }
        }
    }
}
