using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Natures_Prophet
{
    public class NatureProphet
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var garden = new int[dimensions[0], dimensions[1]];

            string inputCurrentPosition;
            while ((inputCurrentPosition = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                var coordinates = inputCurrentPosition.Split(' ').Select(int.Parse).ToArray();
                for (int i = 0; i < dimensions[0]; i++)
                {
                    garden[i, coordinates[1]] += 1;
                }
                for (int i = 0; i < dimensions[1]; i++)
                {
                    if (i == coordinates[1])
                        continue;
                    garden[coordinates[0], i] += 1;
                }
            }

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    output.Append($"{garden[i, j]} ");
                }
                output.AppendLine();
            }
            Console.WriteLine(output);
        }
    }
}
