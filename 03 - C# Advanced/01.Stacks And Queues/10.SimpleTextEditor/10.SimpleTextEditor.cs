using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SimpleTextEditor
{
    public class Program
    {
        public static void Main()
        {
            var operationsNumber = int.Parse(Console.ReadLine());
            var oldText = new Stack<string>();
            var text = "";

            for (int i = 0; i < operationsNumber; i++)
            {
                var operationParams = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                switch (operationParams[0])
                {
                    case "1":
                        oldText.Push(text);
                        text += operationParams[1];
                        break;

                    case "2":
                        oldText.Push(text);
                        var countErase = int.Parse(operationParams[1]);
                        text = text.Substring(0, text.Length - countErase);
                        break;

                    case "3":
                        var indexChar = int.Parse(operationParams[1]);
                        Console.WriteLine(text[indexChar - 1]);
                        break;

                    case "4":
                        text = oldText.Pop();
                        break;
                }
            }
        }
    }
}
