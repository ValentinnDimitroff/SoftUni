using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Lego_Blocks
{
    public class Lego_Blocks
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            var firstArr = FillArray(linesCount);
            var secondArr = FillArray(linesCount);

            secondArr = ReverseJaggedArr(secondArr);

            var matchedArr = MatchArrays(firstArr, secondArr);

            if (ArraysAreMatching(matchedArr))
            {
                PrintJaggedArray(matchedArr);
            }
            else
            {
                PrintCellsNumber(matchedArr);
            }
        }

        private static void PrintCellsNumber(int[][] jaggedArr)
        {
            var count = 0;
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                count += jaggedArr[i].Length;
            }

            Console.WriteLine($"The total number of cells is: {count}");
        }

        private static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("[" + string.Join(", ", jaggedArray[i]) + "]");
            }
        }

        private static bool ArraysAreMatching(int[][] matchedArr)
        {
            var firstLength = matchedArr[0].Length;
            var maxLength = firstLength;
            for (int i = 1; i < matchedArr.Length; i++)
            {
                if (matchedArr[i].Length > maxLength)
                {
                    maxLength = matchedArr[i].Length;
                }
            }

            if (firstLength == maxLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int[][] MatchArrays(int[][] firstArr, int[][] secondArr)
        {
            var matchedArray = new int[firstArr.Length][];
            for (int i = 0; i < firstArr.Length; i++)
            {
                matchedArray[i] = new int[firstArr[i].Length + secondArr[i].Length];
                firstArr[i].CopyTo(matchedArray[i], 0);
                secondArr[i].CopyTo(matchedArray[i], firstArr[i].Length);
            }
            return matchedArray;
        }

        private static int[][] FillArray(int linesCount)
        {
            var arr = new int[linesCount][];
            for (int i = 0; i < linesCount; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                    arr[i] = line;
            }
            return arr;
        }

        private static int[][] ReverseJaggedArr(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Reverse().ToArray();
            }
            return arr;
        }
    }
}
