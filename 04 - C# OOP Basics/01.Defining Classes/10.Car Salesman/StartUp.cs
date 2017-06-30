namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var allEngines = new List<Engine>();

            var numberOfEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineInfo = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                var model = engineInfo[0];
                var power = int.Parse(engineInfo[1]);
                var engine = new Engine(model, power);
                
                if (engineInfo.Length > 2)
                {
                    if (int.TryParse(engineInfo[2], out int displacement))
                        engine.Displacement = displacement;
                    else
                        engine.Efficiency = engineInfo[2];
                }

                if (engineInfo.Length > 3)
                    engine.Efficiency = engineInfo[3];
                
                allEngines.Add(engine);
            }

            var numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = carInfo[0];
                var car = new Car(model, allEngines.Single(e => e.Model == carInfo[1]));

                if (carInfo.Length > 2)
                {
                    if (int.TryParse(carInfo[2], out int weight))
                        car.Weight = weight;
                    else
                        car.Color = carInfo[2];
                }

                if (carInfo.Length > 3)
                    car.Color = carInfo[3];

                Console.WriteLine(car.ToString());
            }
        }
    }
}
