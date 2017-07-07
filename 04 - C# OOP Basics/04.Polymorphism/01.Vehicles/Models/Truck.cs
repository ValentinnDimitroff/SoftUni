namespace _01.Vehicles
{
    using System;

    public class Truck : Vehicle
    {
        private const double ConsumptionModifier = 1.6;
        private const double RefuelingLoss = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        { 
        }
        
        protected override bool Drive(double distance)
        {
            var requiredFuel = distance * (base.FuelConsumptionPerKm + Truck.ConsumptionModifier);
            if (requiredFuel <= base.FuelQuantity)
            {
                base.FuelQuantity -= requiredFuel;
                return true;
            }

            return false;
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * Truck.RefuelingLoss);
        }
    }
}
