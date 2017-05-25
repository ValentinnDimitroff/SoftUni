using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TruckTour
{
    public class Program
    {
        public static void Main()
        {
            var pumpsNumber = long.Parse(Console.ReadLine());
            var petrolStation = new Queue<long[]>();

            for (long i = 0; i < pumpsNumber; i++)
            {
                var pumpInfoParams = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                petrolStation.Enqueue(pumpInfoParams);
            }

            bool reachFinal = false;
            long startingIndex = 0;

            while (!reachFinal)
            {
                long totalAmount = 0;
                
                for (int i = 0; i <= pumpsNumber; i++)
                {
                    if (i == pumpsNumber)
                    {
                        reachFinal = true;
                        break;
                    }

                    var currentStation = petrolStation.Dequeue();
                    petrolStation.Enqueue(currentStation);

                    totalAmount += currentStation[0] - currentStation[1];
                    if (totalAmount  < 0)
                    {
                        startingIndex += i + 1;
                        break;
                    }
                }
            }
            Console.WriteLine(startingIndex);
        }
    }
}
