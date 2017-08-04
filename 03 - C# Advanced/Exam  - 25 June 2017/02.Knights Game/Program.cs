using System;
using System.Collections.Generic;
using System.Linq;

public class KnightsGame
{
    public static void Main()
    {
        int boardSize = int.Parse(Console.ReadLine());
        char[,] chessBoard = new char[boardSize, boardSize];

        FillInTheBoard(chessBoard, boardSize);

        List<int[]> possibleMoves = new List<int[]>
        {
            new[] {-1, -2},
            new[] {-1, 2},
            new[] {1, -2},
            new[] {1, 2},
            new[] {-2, -1},
            new[] {-2, 1},
            new[] {2, -1},
            new[] {2, 1}
        };

        Dictionary<string, int> attackingKinghts = CollectAttackingKnights(chessBoard, possibleMoves);
        int removedKnights = 0;

        while (attackingKinghts.Count > 0)
        {
            KeyValuePair<string, int> mostDangerousKnight = attackingKinghts.OrderByDescending(x => x.Value).First();
            int[] coordinates = mostDangerousKnight.Key
                .Split('|')
                .Select(int.Parse)
                .ToArray();
            chessBoard[coordinates[0], coordinates[1]] = '0';
            RemoveAttackingKnight(attackingKinghts, possibleMoves, coordinates);
            removedKnights++;
        }

        Console.WriteLine(removedKnights);
    }

    private static void FillInTheBoard(char[,] chessBoard, int boardSize)
    {
        for (int rowIndex = 0; rowIndex < boardSize; rowIndex++)
        {
            var rowInfo = Console.ReadLine().Trim().ToCharArray();
            for (int i = 0; i < rowInfo.Length; i++)
            {
                chessBoard[rowIndex, i] = rowInfo[i];
            }
        }
    }

    public static bool IsInMatrix(int row, int col, int boardSize)
    {
        if (row >= 0 && row < boardSize)
        {
            if (col >= 0 && col < boardSize)
            {
                return true;
            }
        }

        return false;
    }

    public static Dictionary<string, int> CollectAttackingKnights(char[,] chessBoard, List<int[]> possibleMoves)
    {
        Dictionary<string, int> attackingKinghts = new Dictionary<string, int>();

        for (int row = 0; row < chessBoard.GetLength(0); row++)
        {
            for (int col = 0; col < chessBoard.GetLength(0); col++)
            {
                if (chessBoard[row, col] != 'K')
                {
                    continue;
                }

                foreach (int[] move in possibleMoves)
                {
                    int[] targetSpot = {row + move[0], col + move[1]};
                    if (IsInMatrix(targetSpot[0], targetSpot[1], chessBoard.GetLength(0)) &&
                        chessBoard[targetSpot[0], targetSpot[1]] == 'K')
                    {
                        string currentKey = row + "|" + col;
                        if (!attackingKinghts.ContainsKey(currentKey))
                        {
                            attackingKinghts[currentKey] = 0;
                        }
                        attackingKinghts[currentKey]++;
                    }
                }
            }
        }

        return attackingKinghts;
    }

    public static void RemoveAttackingKnight(Dictionary<string, int> attackingKinghts, List<int[]> possibleMoves, int[] coordinates)
    {
        string knightToRemoveKey = coordinates[0] + "|" + coordinates[1];
        attackingKinghts.Remove(knightToRemoveKey);

        foreach (int[] move in possibleMoves)
        {
            string targetKey = (coordinates[0] + move[0] ) + "|" + (coordinates[1] + move[1]);
            if (attackingKinghts.ContainsKey(targetKey))
            {
                attackingKinghts[targetKey]--;

                if (attackingKinghts[targetKey] == 0)
                {
                    attackingKinghts.Remove(targetKey);
                }
            }
        }
    }
}