using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var allCars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                var car = new Car(
                    carInfo[0],
                    int.Parse(carInfo[1]),
                    int.Parse(carInfo[2]),
                    int.Parse(carInfo[3]),
                    carInfo[4],
                    double.Parse(carInfo[5]),
                    int.Parse(carInfo[6]),
                    double.Parse(carInfo[7]),
                    int.Parse(carInfo[8]),
                    double.Parse(carInfo[9]),
                    int.Parse(carInfo[10]),
                    double.Parse(carInfo[11]),
                    int.Parse(carInfo[12]));

                allCars.Add(car);
            }

            var command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    allCars
                        .Where(c => c.Cargo.Type == command && c.Tires.Any(t => t.Pressure < 1))
                        .Select(c => c.Model)
                        .ToList()
                        .ForEach(c => Console.WriteLine(c));
                    break;
                case "flamable":
                    allCars
                        .Where(c => c.Cargo.Type == command && c.Engine.Power > 250)
                        .Select(c => c.Model)
                        .ToList()
                        .ForEach(c => Console.WriteLine(c));
                    break;
            }
        }
    }
}
