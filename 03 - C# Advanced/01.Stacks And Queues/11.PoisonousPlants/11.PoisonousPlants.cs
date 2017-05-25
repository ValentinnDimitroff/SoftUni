using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PoisonousPlants
{
    public class Program
    {
        public static void Main()
        {
            var plantsNumber = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var dayPlantsDeath = new int[plantsNumber];
            var prevPlants = new Stack<int>(); //the last number + every other non consecutive
            prevPlants.Push(0);

            for (int i = 1; i < plantsNumber; i++)
            {
                int maxDays = 0;
                while (prevPlants.Count > 0 && plants[prevPlants.Peek()] >= plants[i]) //is the current plant in correct order
                {
                    maxDays = Math.Max(maxDays, dayPlantsDeath[prevPlants.Pop()]); //safe before the day this plant dies (if 0 - forever)
                }

                if (prevPlants.Count > 0) //finally the plant will die because of lower number downwards
                {
                    dayPlantsDeath[i] = maxDays + 1; //today
                }
                prevPlants.Push(i); //save the last plant
            }

            Console.WriteLine(dayPlantsDeath.Max());
        }
    }
}