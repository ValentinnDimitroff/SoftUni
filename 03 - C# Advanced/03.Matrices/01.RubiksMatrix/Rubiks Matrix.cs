using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RubiksMatrix
{
    public class Rubiks_Matrix
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            var commandsCount = int.Parse(Console.ReadLine());

            var cube = new int[rows, cols];
            cube = AssingCubeValues(cube, dimensions);
            
            for (int i = 0; i < commandsCount; i++)
            {
                var commandToken = Console.ReadLine()
                    .Split();
                var rcIndex = int.Parse(commandToken[0]);
                var direction = commandToken[1];
                var movesCount = int.Parse(commandToken[2]);

                switch (direction)
                {
                    case "up":
                        cube = ShiftUpCube(cube, dimensions, rcIndex, movesCount % rows);
                        break;
                    case "down":
                        cube = ShiftDownCube(cube, dimensions, rcIndex, movesCount % rows);
                        break;
                    case "left":
                        cube = ShiftLeftCube(cube, dimensions, rcIndex, movesCount % cols);
                        break;
                    case "right":
                        cube = ShiftRightCube(cube, dimensions, rcIndex, movesCount % cols);
                        break;
                }
            }
            var originalCube = new int[rows, cols];
            originalCube = AssingCubeValues(originalCube, dimensions);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (cube[row,col] == originalCube[row, col])
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        cube = SwapCube(cube, originalCube, row, col);
                    }
                }
            }
        }

        private static int[,] SwapCube(int[,] cube, int[,] originalCube, int row, int col)
        {
            for (int r = 0; r < cube.GetLength(0); r++)
            {
                for (int c = 0; c < cube.GetLength(1); c++)
                {
                    if (originalCube[row, col] == cube[r, c])
                    {
                        cube[r, c] = cube[row, col];
                        cube[row, col] = originalCube[row, col];
                        Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                    }
                }
            }

            return cube;
        }

        private static int[,] ShiftLeftCube(int[,] cube, int[] dimensions, int rcIndex, int movesCount)
        {
            for (int i = 0; i < movesCount; i++)
            {
                var memo = cube[rcIndex, 0];
                for (int col = 0; col < dimensions[1] - 1; col++)
                {
                    cube[rcIndex, col] = cube[rcIndex, col + 1];
                }
                cube[rcIndex, dimensions[1] - 1] = memo;
            }

            return cube;
        }

        private static int[,] ShiftRightCube(int[,] cube, int[] dimensions, int rcIndex, int movesCount)
        {
            for (int i = 0; i < movesCount; i++)
            {
                var memo = cube[rcIndex, dimensions[1] - 1];
                for (int col = dimensions[1] - 1; col > 0; col--)
                {
                    cube[rcIndex, col] = cube[rcIndex, col - 1];
                }
                cube[rcIndex, 0] = memo;
            }

            return cube;
        }

        private static int[,] ShiftDownCube(int[,] cube, int[] dimensions, int rcIndex, int movesCount)
        {
            for (int i = 0; i < movesCount; i++)
            {
                var memo = cube[dimensions[0] - 1, rcIndex];
                for (int row = dimensions[0] - 1; row > 0 ; row--)
                {
                    cube[row, rcIndex] = cube[row - 1, rcIndex];
                }
                cube[0, rcIndex] = memo;
            }

            return cube;
        }

        private static int[,] ShiftUpCube(int[,] cube, int[] dimensions, int rcIndex, int movesCount)
        {
            for (int i = 0; i < movesCount; i++)
            {
                var memo = cube[0, rcIndex];
                for (int row = 0; row < dimensions[0] - 1; row++)
                {
                    cube[row, rcIndex] = cube[row + 1, rcIndex];
                }
                cube[dimensions[0] - 1, rcIndex] = memo;
            }

            return cube;
        }

        private static int[,] AssingCubeValues(int[,] cube, int[] dimensions)
        {
            var element = 1;
            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    cube[i, j] = element;
                    element++;
                }
            }

            return cube;
        }
    }
}
