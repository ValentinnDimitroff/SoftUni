using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Parking_System
{
    public class ParkingSystem
    {
        private static Dictionary<int, HashSet<int>> spotsTaken = 
            new Dictionary<int, HashSet<int>>();
        private static int parkingRows;
        private static int parkingCols;

        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            parkingRows = dimensions[0];
            parkingCols = dimensions[1];
            spotsTaken = new Dictionary<int, HashSet<int>>(); //No need to check explictly

            var command = Console.ReadLine();

            while (command != "stop")
            {
                var carTokens = command
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var entryRow = carTokens[0];
                var desiredRow = carTokens[1];
                var desiredCol = carTokens[2];

                if (IsSpotTaken(desiredRow, desiredCol))
                {
                    desiredCol = TryFindFreeSpot(desiredRow, desiredCol);
                }

                // targetCol value of 0 means a row is full
                if (desiredCol > 0)
                {
                    MarkSpotAsTaken(desiredRow, desiredCol);

                    int distance = Math.Abs(desiredRow - entryRow) + desiredCol + 1;
                    Console.WriteLine(distance);
                }
                else
                {
                    Console.WriteLine($"Row {desiredRow} full");
                }

                command = Console.ReadLine();
            }
        }

        private static void MarkSpotAsTaken(int desiredRow, int desiredCol)
        {
            if (!spotsTaken.ContainsKey(desiredRow))
            {
                spotsTaken[desiredRow] = new HashSet<int>();
            }
            spotsTaken[desiredRow].Add(desiredCol);
        }

        private static int TryFindFreeSpot(int desiredRow, int desiredCol)
        {
            int newCol = 0;
            int bestLength = int.MaxValue;
            for (int col = 1; col < parkingCols; col++)
            {
                if (!IsSpotTaken(desiredRow, col))
                {
                    int newLength = Math.Abs(desiredCol - col);
                    if (newLength < bestLength)
                    {
                        bestLength = newLength;
                        newCol = col;
                    }
                }
            }

            return newCol;
        }

        private static bool IsSpotTaken(int desiredRow, int desiredCol)
        {
            return spotsTaken.ContainsKey(desiredRow) &&
                spotsTaken[desiredRow].Contains(desiredCol);
        }
    }
}