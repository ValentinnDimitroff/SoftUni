using System;
using System.Collections.Generic;
using System.Linq;

public class SecondNature
{
    public static void Main()
    {
        var flowers = new Stack<int>(Console.ReadLine()
            .Split(' ')
            .Select(int.Parse).ToArray().Reverse());
        var buckets = new Stack<int>(Console.ReadLine()
            .Split(' ')
            .Select(int.Parse));
        var secondNatureFlowers = new List<int>();

        while (flowers.Count > 0 && buckets.Count > 0)
        {
            var currentFlower = flowers.Pop();
            while (buckets.Count > 0 && currentFlower - buckets.Peek() > 0)
                currentFlower -= buckets.Pop();

            int remainingWater = 0;
            if (buckets.Count > 0)
            {
                if (currentFlower - buckets.Peek() < 0)
                {
                    remainingWater = buckets.Pop() - currentFlower;
                    currentFlower = -1;
                }
                else
                {
                    secondNatureFlowers.Add(currentFlower);
                    buckets.Pop();
                    currentFlower = -1;
                }

                if (buckets.Count > 0)
                    buckets.Push(buckets.Pop() + remainingWater);
                else if (remainingWater != 0)
                    buckets.Push(remainingWater);
            }
           
            if (currentFlower > 0)
                flowers.Push(currentFlower);
        }

        if (buckets.Count > 0)
            Console.WriteLine(string.Join(" ", buckets));
        else
            Console.WriteLine(string.Join(" ", flowers));

        if (secondNatureFlowers.Any())
            Console.WriteLine(string.Join(" ", secondNatureFlowers));
        else
            Console.WriteLine("None");
    }
}