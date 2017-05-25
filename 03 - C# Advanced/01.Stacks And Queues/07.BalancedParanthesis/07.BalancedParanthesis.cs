using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BalancedParanthesis
{
    public class Program
    {
        public static void Main()
        {
            var paranthesisLine = Console.ReadLine();
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
                    if (openedParanths.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (symbol)
                    {
                        case ')':
                            if (openedParanths.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }

                            break;

                        case ']':
                            if (openedParanths.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;

                        case '}':
                            if (openedParanths.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}