using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var allCars = new Dictionary<string, Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                var car = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
                allCars[carInfo[0]] = car;
            }
            string driveLine;
            while ((driveLine = Console.ReadLine()) != "End")
            {
                var driveInfo = driveLine.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var model = driveInfo[1];
                var distance = int.Parse(driveInfo[2]);
                allCars[model].Drive(distance);
            }

            foreach (var car in allCars)
            {
                Console.WriteLine(car.Value.PrintCarInfo());
            }
        }
    }
}
