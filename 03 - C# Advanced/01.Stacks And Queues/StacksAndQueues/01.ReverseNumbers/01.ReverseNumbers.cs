using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseNumbers
{
    public class Program
    {
        public static void Main()
        {
            int[] inputNumbers = Console.ReadLine()
                .Split( new[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>();
            int count = inputNumbers.Length;

            for (int i = 0; i < count;  i++)
            {
                numbers.Push(inputNumbers[i]);
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(numbers.Pop() + " ");
            }
        }
    }
}
