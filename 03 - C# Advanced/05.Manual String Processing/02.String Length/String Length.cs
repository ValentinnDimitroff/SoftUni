using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.String_Length
{
    public class StringLength
    {
        public static void Main()
        {
            string inputStr = string.Empty;
            while (inputStr.Length <= 20)
            {
                //char c = Console.ReadKey().KeyChar;
                char c = (char) Console.Read();
                if (c == '\r')
                {
                    Console.WriteLine();
                    break;
                }
                inputStr += c;
            }
            
            inputStr = inputStr.PadRight(20, '*');
            Console.WriteLine(inputStr);
        }
    }
}
