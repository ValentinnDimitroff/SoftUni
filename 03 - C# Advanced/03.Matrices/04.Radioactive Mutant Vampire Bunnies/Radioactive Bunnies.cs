using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Radioactive_Mutant_Vampire_Bunnies
{
    public class RadioactiveBunnies
    {
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

            var lair = new char[rows][];
            var playerRow = 0;
            var playerCol = 0;
            for (int i = 0; i < rows; i++)
            {
                lair[i] = Console.ReadLine().ToArray();
                if (lair[i].Contains('P'))
                {
                    playerRow = i;
                    playerCol = Array.IndexOf(lair[i], 'P');
                    lair[playerRow][playerCol] = '.';
                }
            }
            
            var moves = Console.ReadLine();        
            foreach (var move in moves)
            {
                int oldPlayerRow = playerRow;
                int oldPlayerCol = playerCol;

                switch (move)
                {
                    case 'U': playerRow--; break;
                    case 'D': playerRow++; break;
                    case 'L': playerCol--; break;
                    case 'R': playerCol++; break;
                }

                lair = BunniesSpread(lair);

                if (playerRow < 0 || playerRow >= lair.Length
                    || playerCol < 0 || playerCol >= lair[0].Length)
                {
                    PrintResult(lair, oldPlayerRow, oldPlayerCol, "won");
                    return;
                }

                if (lair[playerRow][playerCol] == 'B')
                {
                    PrintResult(lair, playerRow, playerCol, "dead");
                    return;
                }
            }
        }

        private static void PrintResult(char[][] jaggedArray, int playerRow, int playerCol, string condition)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join("", jaggedArray[i]));
            }

            Console.WriteLine($"{condition}: {playerRow} {playerCol}");
        }

        private static char[][] BunniesSpread(char[][] lair)
        {
            char[][] tempLair = new char[lair.Length][];
            for (int i = 0; i < lair.Length; i++)
            {
                tempLair[i] = lair[i].ToArray();
            }

            for (int row = 0; row < lair.Length; row++)
            {
                for (int col = 0; col < lair[row].Length; col++)
                {
                    if (lair[row][col] != 'B')
                    {
                        continue;
                    }
                    
                    if (col > 0) tempLair[row][col - 1] = 'B';
                    if (col < lair[row].Length - 1) tempLair[row][col + 1] = 'B';
                    if (row > 0) tempLair[row - 1][col] = 'B';
                    if (row < lair.Length - 1) tempLair[row + 1][col] = 'B';
                }
            }

            return tempLair;
        }
    }
}
