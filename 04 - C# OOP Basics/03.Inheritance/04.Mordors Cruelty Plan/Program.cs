namespace MordorsCrueltyPlan
{
    using System;
    using Factories;
    using Foods;
    using Moods;
    using _04.Mordors_Cruelty_Plan;

    public class Program
    {
        public static void Main()
        {
            var gandalf = new Gandalf();

            var inputFood = Console.ReadLine().Split(new[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var foodStr in inputFood)
            {
                Food food = FoodFactory.MakeFood(foodStr);
                gandalf.Eat(food);
            }

            int totalHapinessPoints = gandalf.GetHapinessPoints();
            Mood currentMood = MoodFactory.GetCorrespondingMood(totalHapinessPoints);

            Console.WriteLine(totalHapinessPoints);
            Console.WriteLine(currentMood);
        }
    }
}
