namespace MordorsCrueltyPlan
{
    using System;
    using System.Collections.Generic;
    using Factories;
    using Foods;

    public class Program
    {
        public static void Main()
        {
            var foodsStr = Console.ReadLine()
                .Split(new char[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var foods = new List<Food>();
            var moodFactor = 0;

            foreach (var item in foodsStr)
            {
                foods.Add(FoodFactory.MakeFood(item));
            }

            foreach (var food in foods)
            {
                moodFactor += food.GetHappinessPoints();
            }

            Console.WriteLine(moodFactor);
            Console.WriteLine(MoodFactory.GetCorrespondingMood(moodFactor));
        }
    }
}
