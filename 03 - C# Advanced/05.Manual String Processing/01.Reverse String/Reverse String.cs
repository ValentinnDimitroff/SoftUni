using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    public class ReverseString
    {
        public static void Main()
        {
            //var s = new Stopwatch();
            //s.Start();

            //var inputStr = Console.ReadLine().ToCharArray().Reverse().ToArray();
            //Console.WriteLine(string.Join("", inputStr));

            //var stack = new Stack<char>(Console.ReadLine());
            //Console.WriteLine(stack.ToString());

            var inputStr = Console.ReadLine().ToCharArray();
            Array.Reverse(inputStr);
            Console.WriteLine(inputStr);

            //s.Stop();
            //Console.WriteLine(s.ElapsedTicks);
        }
    }
}
