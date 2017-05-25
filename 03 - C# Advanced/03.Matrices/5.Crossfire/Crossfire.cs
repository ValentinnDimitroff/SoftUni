using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5.Crossfire
{
    public class Crossfire
    {
        //author: Valentin Dimitrov
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
                //if (IsInMatrix(rowShot, 0, matrix))
                //{
                    for (int col = colShot - radius; col <= colShot + radius; col++)
                    {
                        if (IsInMatrix(rowShot, col, matrix))
                        {
                            matrix[rowShot][col] = -1;
                        }
                    }
                //}

                //if (IsInMatrix(0, colShot, matrix))
                //{
                    for (int row = rowShot - radius; row <= rowShot + radius; row++)
                    {
                        if (IsInMatrix(row, colShot, matrix))
                        {
                            matrix[row][colShot] = -1;
                        }
                    }
                //}

                matrix = FilterMatrix(matrix);
                command = Console.ReadLine();
            }
            PrintJaggedArray(matrix);
        }

        private static List<List<int>> FilterMatrix(List<List<int>> matrix)
        {
            //Search the matrix upside down because the Count changes all the time
            for (int row = matrix.Count - 1; row >= 0; row--)
            {
                for (int col = matrix[row].Count - 1; col >= 0; col--)
                {
                    if (matrix[row][col] == -1)
                    {
                        matrix[row].RemoveAt(col);
                    }
                }
                //Delete empty rows - four tests
                if (matrix[row].Count == 0)
                {
                    matrix.RemoveAt(row);
                }
            }
            return matrix;
        }

        private static void PrintJaggedArray(List<List<int>> matrix)
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }

        private static bool IsInMatrix(int currentRow, int currentCol, List<List<int>> matrix)
        {
            return currentRow >= 0 && currentRow < matrix.Count && 
                   currentCol >= 0 && currentCol < matrix[currentRow].Count;
        }

        private static List<List<int>> InitializeMatrix(int[] dimensions)
        {
            var matrix = new List<List<int>>();
            var element = 1;
            for (int row = 0; row < dimensions[0]; row++)
            {
                matrix.Add(new List<int>()); 
                for (int col = 0; col < dimensions[1]; col++)
                {
                    matrix[row].Add(element);
                    element++;
                }
            }

            return matrix;
        }
    }
}