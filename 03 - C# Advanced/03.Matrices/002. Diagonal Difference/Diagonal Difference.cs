using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Diagonal_Difference
{
    public class DiagonalDifference
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            FillMatrix(n, matrix);
            int sumPrimary = 0, sumSecondary = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        sumPrimary += matrix[row, col];
                    }
                    if (row == n - col - 1)
                    {
                        sumSecondary += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(sumPrimary - sumSecondary));
        }

       private static void FillMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            //return matrix;
        }
    }
}
