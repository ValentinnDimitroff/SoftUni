namespace _04.Mordors_Cruelty_Plan
{
    using System.Collections.Generic;
    using System.Linq;
    using MordorsCrueltyPlan.Foods;

    public class Gandalf
    {
        private List<Food> foodEaten;

        public Gandalf()
        {
            this.foodEaten = new List<Food>();
        }

        public void Eat(Food food)
        {
            this.foodEaten.Add(food);
        }

        public int GetHapinessPoints()
        {
            return foodEaten.Sum(f => f.GetHappinessPoints());
        }

    }
}
