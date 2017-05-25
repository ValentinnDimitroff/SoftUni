using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5.Crossfire
{
    public class Crossfire
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var matrixRows = dimensions[0];
            var matrixCols = dimensions[1];

            var matrix = InitializeMatrix(dimensions);
            var command = Console.ReadLine();
            while (command != "Nuke it from orbit")
            {
                var tokens = command
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int rowShot = tokens[0], colShot = tokens[1], radius = tokens[2];
                //var beginRow = tokens[0] - tokens[2] >= 0 ? tokens[0] - tokens[2] : 0;
                //var endRow = tokens[0] + tokens[2] < rows ? tokens[0] + tokens[2] : rows -1;
                //var beginCol = tokens[1] - tokens[2] >= 0 ? tokens[1] - tokens[2] : 0;
                //var endCol = tokens[1] + tokens[2] < cols ? tokens[1] + tokens[2] : cols - 1;
                if (IsInMatrix(rowShot, 0, matrix))
                {
                    for (int col = colShot - radius; col <= colShot + radius; col++)
                    {
                        if (IsInMatrix(rowShot, col, matrix))
                        {
                            matrix[rowShot][col] = -1;
                        }
                    }
                }

                if (IsInMatrix(0, colShot, matrix))
                {
                    for (int row = rowShot - radius; row <= rowShot + radius; row++)
                    {
                        if (IsInMatrix(row, colShot, matrix))
                        {
                            matrix[row][colShot] = -1;
                            //matrix[row] = matrix[row].Where(a => a != -1).ToArray();
                            //if (matrix[row].Length == 0)
                            //{
                            //    matrix = matrix.Where((arr, i) => i != row).ToArray();
                            //}
                        }
                    }
                }

                matrix = FilterMatrix(matrix);
                //if (IsInMatrix(rowShot, 0, matrix))
                //{
                //    matrix[rowShot] = matrix[rowShot].Where(a => a != -1).ToArray();
                //    if (matrix[rowShot].Length == 0)
                //    {
                //        matrix = matrix.Where((arr, i) => i != rowShot).ToArray();
                //    }
                //}
                command = Console.ReadLine();
            }
            PrintJaggedArray(matrix);
        }

        private static int[][] FilterMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = matrix[row].Where(x => x != -1).ToArray();
            }
            return matrix;
        }

        private static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }

        private static bool IsInMatrix(int currentRow, int currentCol, int[][] matrix)
        {
            return currentRow >= 0 && currentRow < matrix.Length && 
                   currentCol >= 0 && currentCol < matrix[currentRow].Length;
        }

        private static int[][] InitializeMatrix(int[] dimensions)
        {
            var matrix = new int[dimensions[0]][];
            var element = 1;
            for (int row = 0; row < dimensions[0]; row++)
            {
                matrix[row] = new int[dimensions[1]];
                for (int col = 0; col < dimensions[1]; col++)
                {
                    matrix[row][col] = element;
                    element++;
                }
            }

            return matrix;
        }
    }
}