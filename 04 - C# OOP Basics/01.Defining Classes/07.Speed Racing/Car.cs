using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private int distanceTraveled;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.distanceTraveled = 0;
        }

        public void Drive(int kilometers)
        {
            double neededFuel = fuelConsumption * kilometers;
            if (neededFuel > this.fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuelAmount -= neededFuel;
                this.distanceTraveled += kilometers;
            }
        }

        public string PrintCarInfo()
        {
            return $"{this.model} {this.fuelAmount:f2} {this.distanceTraveled}";
        }
    }
}
