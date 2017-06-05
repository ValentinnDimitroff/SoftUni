using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Character_Multiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            var inputStrings = Console.ReadLine()
                .Split(' ');
            
            var firstString = new Queue<char>(inputStrings[0]);
            var secondString = new Queue<char>(inputStrings[1]);
            var totalSum = 0;

            while (firstString.Count > 0 || secondString.Count > 0)
            {
                var sum = 1;
                if (firstString.Count > 0) sum *= firstString.Dequeue();
                if (secondString.Count > 0) sum *= secondString.Dequeue();

                totalSum += sum;
            }

            Console.WriteLine(totalSum);
        }
    }
}
