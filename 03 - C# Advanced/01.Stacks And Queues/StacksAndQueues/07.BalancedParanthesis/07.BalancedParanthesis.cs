using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BalancedParanthesis
{
    public class Program
    {
        public static void Main()
        {
            var paranthesisLine = Console.ReadLine();
            var mismatch = false;
            var openingCases = new[] { '{', '[', '(' };
            var openedParanths = new Stack<char>();

            foreach (var symbol in paranthesisLine)
            {
                if (openingCases.Contains(symbol))
                {
                    openedParanths.Push(symbol);
                }
                else
                {
                    if (openedParanths.Count != 0)
                    {
                        switch (symbol)
                        {
                            case ')':
                                if (openedParanths.Pop() != '(')
                                    mismatch = true;
                                break;
                            case ']':
                                if (openedParanths.Pop() != '[')
                                    mismatch = true;
                                break;
                            case '}':
                                if (openedParanths.Pop() != '{')
                                    mismatch = true;
                                break;
                        }
                    }
                    else
                    {
                        mismatch = true;
                    }
                }
            }

            if (mismatch)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
}
