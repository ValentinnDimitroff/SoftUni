using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.TruckTour
{
    public class Program
    {
        public static void Main()
        {
            var pumpsNumber = long.Parse(Console.ReadLine());
            var petrolAmounts = new Queue<long>();
            var distancesToNextPump = new Queue<long>();

            for (long i = 0; i < pumpsNumber; i++)
            {
                var pumpInfoParams = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                petrolAmounts.Enqueue(pumpInfoParams[0]);
                distancesToNextPump.Enqueue(pumpInfoParams[1]);
            }

            var reachedTheLast = false;
            long startingPumpIndex = 0;
            while (!reachedTheLast)
            {
                BigInteger totalAmount = 0;
                reachedTheLast = true;
                for (long i = 0; i < pumpsNumber; i++)
                {
                    var currentAmount = petrolAmounts.Dequeue();
                    var currentDistance = distancesToNextPump.Dequeue();
                    petrolAmounts.Enqueue(currentAmount);
                    distancesToNextPump.Enqueue(currentDistance);

                    totalAmount += currentAmount;
                    if (totalAmount - currentDistance < 0)
                    {
                        startingPumpIndex += i + 1;
                        reachedTheLast = false;
                        break;
                    }                    
                }                
            }

            Console.WriteLine(startingPumpIndex);
        }
    }
    public class PetrolStation
    {
        public long amount;
        public long distanceNext;
        public long index;
        public void Build(long amount, long distanceNext, long index) {
            this.amount = amount;
            this.distanceNext = distanceNext;
            this.index = index;
        }
    }
}
