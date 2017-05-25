using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Radioactive_Mutant_Vampire_Bunnies
{
    public class RadioactiveBunnies
    {
        private static char[][] lair = new char[1][];
        private static bool isDead = false;
        private static bool hasWon = false;

        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];

            lair = FillTheLair(rows);
            var playerPos = FindPlayer(lair);
            var moves = Console.ReadLine();            

            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'U':
                        MovePlayer(playerPos, -1, 0);
                        if (!hasWon) playerPos[0]--;
                        break;
                    case 'D':
                        MovePlayer(playerPos, +1, 0);
                        if (!hasWon) playerPos[0]++;
                        break;
                    case 'L':
                        MovePlayer(playerPos, 0, -1);
                        if (!hasWon) playerPos[1]--;
                        break;
                    case 'R':
                        MovePlayer(playerPos, 0, 1);
                        if (!hasWon) playerPos[1]++;
                        break;
                }

                lair = BunniesSpread();
                if (hasWon || isDead)
                {
                    break;
                }
            }

            PrintJaggedArray(lair);

            var condition = "";
            if (isDead)
                condition = "dead";
            else if (hasWon)
                condition = "won";
            Console.WriteLine($"{condition}: {playerPos[0]} {playerPos[1]}");
        }

        private static void PrintJaggedArray(char[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join("", jaggedArray[i]));
            }
        }

        private static char[][] BunniesSpread()
        {
            char[][] tempLair = new char[lair.Length][];
            for (int i = 0; i < lair.Length; i++)
            {
                tempLair[i] = lair[i].Select(x => x).ToArray();
            }

            for (int row = 0; row < lair.Length; row++)
            {
                for (int col = 0; col < lair[row].Length; col++)
                {
                    if (lair[row][col] != 'B')
                    {
                        continue;
                    }
                    
                    if (CheckFreeSpace(col -1, row))
                    {
                        tempLair[row][col - 1] = 'B';
                    }
                    if (CheckFreeSpace(col + 1, row))
                    {
                        tempLair[row][col + 1] = 'B';
                    }
                    if (CheckFreeSpace(col, row - 1))
                    {
                        tempLair[row - 1][col] = 'B';
                    }
                    if (CheckFreeSpace(col, row + 1))
                    {
                        tempLair[row + 1][col] = 'B';
                    }
                }
            }
            return tempLair;
        }

        private static bool CheckFreeSpace(int col, int row)
        {
            if (row >= 0 && row <= lair.Length - 1 && col >= 0 && col <= lair[row].Length - 1)
            {
                if (lair[row][col] == 'P')
                {
                    isDead = true;
                }
                return true;
            }
            return false;
        }

        private static void MovePlayer(int[] playerPos, int newRow, int newCol)
        {
            if (playerPos[0] + newRow >= 0 && playerPos[0] + newRow <= lair.Length - 1
                && playerPos[1] + newCol >= 0 && playerPos[1] + newCol <= lair[0].Length - 1)
            {
                if (lair[playerPos[0] + newRow][playerPos[1] + newCol] == 'B')
                {
                    isDead = true;
                }
                else
                {
                    lair[playerPos[0] + newRow][playerPos[1] + newCol] = 'P';
                    lair[playerPos[0]][playerPos[1]] = '.';
                }
            }
            else
            {
                hasWon = true;
                lair[playerPos[0]][playerPos[1]] = '.';
            }            
        }

        private static int[] FindPlayer(char[][] lair)
        {
            var position = new int[2];
            for (int row = 0; row < lair.Length; row++)
            {
                for (int col = 0; col < lair[row].Length; col++)
                {
                    if (lair[row][col] == 'P')
                    {
                        position[0] = row;
                        position[1] = col;
                        return position;
                    }
                }
            }
            return position;
        }

        private static char[][] FillTheLair(int rows)
        {
            var lair = new char[rows][];

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                var lairLine = Console.ReadLine()
                    .ToArray();
                lair[row] = lairLine;
            }

            return lair;
        }
    }
}
