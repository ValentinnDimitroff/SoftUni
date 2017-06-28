namespace DateMod
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            var fistDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var dateMod = new DateModifier();
            dateMod.CalculateDifference(fistDate, secondDate);

            Console.WriteLine(dateMod.DaysBetween);
        }
    }
}
