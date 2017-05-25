using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _003.Square_In_Matrixes
{
    public class SquareInMatrixes
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var matrix = FillMatrix(dimensions);
            var count = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if ((matrix[row, col] == matrix[row, col + 1]) &&
                        (matrix[row, col] == matrix[row + 1, col]) &&
                        (matrix[row, col] == matrix[row + 1, col + 1]))
                    {
                        count++;
                    } 
                }
            }

            Console.WriteLine(count);
        }

        private static char[,] FillMatrix(int[] dimensions)
        {
            var rows = dimensions[0];
            var cols = dimensions[1];
            var matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
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
