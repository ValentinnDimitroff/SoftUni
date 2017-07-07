namespace _01.Vehicles
{
    using System;

    public class Car : Vehicle
    {
        private const double ConsumptionModifier = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
        }

        protected override bool Drive(double distance)
        {
            var requiredFuel = distance * (base.FuelConsumptionPerKm + Car.ConsumptionModifier);
            if (requiredFuel <= base.FuelQuantity)
            {
                base.FuelQuantity -= requiredFuel;
                return true;
            }

            return false;
        }
    }
}
