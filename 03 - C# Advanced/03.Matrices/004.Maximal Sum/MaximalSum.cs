using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004.Maximal_Sum
{
    public class MaximalSum
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var matrix = FillMatrix(dimensions);
            var maxSum = 0;
            var startingIndex = new int[2];
            for (int row = 0; row < dimensions[0] - 2; row++)
            {
                for (int col = 0; col < dimensions[1] - 2; col++)
                {
                    var sum = Sum3by3Matrix(matrix, row, col);
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        startingIndex[0] = row;
                        startingIndex[1] = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = startingIndex[0]; row < startingIndex[0] + 3; row++)
            {
                for (int col = startingIndex[1]; col < startingIndex[1] + 3; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }

        }

        private static int Sum3by3Matrix(int[,] matrix, int startRow, int startCol)
        {
            var sum = 0;
            for (int row = startRow; row < startRow + 3; row++)
            {   
                for (int col = startCol; col < startCol + 3; col++)
                {
                    sum += matrix[row, col];
                }
            }

            return sum;
        }

        private static int[,] FillMatrix(int[] dimensions)
        {
            var rows = dimensions[0];
            var cols = dimensions[1];
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            return matrix;
        }
    }
}
