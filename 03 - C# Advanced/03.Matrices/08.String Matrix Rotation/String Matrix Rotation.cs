using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08.String_Matrix_Rotation
{
    public class MatrixRotation
    {
        public static void Main()
        {
            var inputLines = new List<string>();
            var rotationDegrees = int.Parse(Regex.Match(Console.ReadLine(), @"\d+").Value);
            var line = Console.ReadLine();
            var maxLenght = int.MinValue;

            while (line != "END")
            {
                inputLines.Add(line);
                if (line.Length > maxLenght)
                {
                    maxLenght = line.Length;
                }
                line = Console.ReadLine();
            }

            var matrix = new char[inputLines.Count, maxLenght];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col < inputLines[row].Length)
                    {
                        matrix[row, col] = inputLines[row][col];
                    }
                    else
                    {
                        //Otherwise just null
                        matrix[row, col] = ' ';
                    }
                }
            }
            
            switch (rotationDegrees % 360 / 90)
            {
                case 0:
                    PrintHorizontalStraigthMatrix(matrix);
                    break;
                case 1:
                    PrintVerticalStraightMatrix(matrix);
                    break;
                case 2: 
                    PrintHorizontalReversedMatrix(matrix);
                    break;
                case 3:
                    PrintVerticalReversedMatrix(matrix);
                    break;
            }
        }

        private static void PrintVerticalReversedMatrix(char[,] matrix)
        {
            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintVerticalStraightMatrix(char[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintHorizontalStraigthMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintHorizontalReversedMatrix(char[,] matrix)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
