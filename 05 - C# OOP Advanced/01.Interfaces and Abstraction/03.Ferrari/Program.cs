namespace _03.Ferrari
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string driversName = Console.ReadLine();
            var ferrari = new Ferrari(driversName);
            Console.WriteLine(ferrari);

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}
