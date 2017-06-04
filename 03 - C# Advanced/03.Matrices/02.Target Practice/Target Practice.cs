using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Target_Practice
{
    public class Target_Practice
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var snakeString = Console.ReadLine();
            var stairs = FillTheStairs(dimensions[0], dimensions[1], snakeString);
            
            var shot = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            stairs = ShotFired(shot, stairs);
            stairs = DropLeft(stairs);
            PrintStairs(stairs);
        }

        private static char[,] DropLeft(char[,] stairs)
        {
            for (int col = 0; col < stairs.GetLength(1); col++)
            {
                for (int row = stairs.GetLength(0) - 1; row >= 0; row--)
                {
                    if (stairs[row, col] == ' ')
                    {
                        var nextValidRow = row - 1;
                        while (nextValidRow >= 0)
                        {
                            if (stairs[nextValidRow, col] != ' ')
                            {
                                stairs[row, col] = stairs[nextValidRow, col];
                                stairs[nextValidRow, col] = ' ';
                                row--;
                            }
                            nextValidRow--;
                        }
                    }
                }
            }
            return stairs;
        }

        private static void PrintStairs(char[,] stairs)
        {
            for (int row = 0; row < stairs.GetLength(0); row++)
            {
                Console.WriteLine();
                for (int col = 0; col < stairs.GetLength(1); col++)
                {
                    Console.Write(stairs[row,col]);
                }
            }
        }
  
        private static char[,] ShotFired(int[] shot, char[,] stairs)
        {
            for (int i = 0; i < stairs.GetLength(0); i++)
            {
                for (int j = 0; j < stairs.GetLength(1); j++)
                {
                    if (IsInsideRadius(i, j, shot[0], shot[1], shot[2]))
                    {
                        stairs[i, j] = ' ';
                    }
                }
            }
            return stairs;
        }

        private static bool IsInsideRadius(int checkRow, int checkCol, int impactRow, int impactCol, int shotRadius)
        {
            int deltaRow = checkRow - impactRow;
            int deltaCol = checkCol - impactCol;

            bool isInRadius = deltaRow * deltaRow + deltaCol * deltaCol <= shotRadius * shotRadius;
            return isInRadius;
        }

        private static char[,] FillTheStairs(int rows, int cols, string snakeString)
        {
            var stairs = new char[rows, cols];
            var elementNumber = 0;
            for (int row = rows - 1, direction = 0; row >= 0; row--, direction++)
            {
                if (direction % 2 == 0)
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        stairs[row, col] = snakeString[elementNumber % snakeString.Length];
                        elementNumber++;
                    }
                }
                else
                {
                    for (int col = 0; col < cols; col++)
                    {
                        stairs[row, col] = snakeString[elementNumber % snakeString.Length];
                        elementNumber++;
                    }
                }                
            }

            return stairs;
        }
    }
}
