using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;
        
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
            double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3age,
            double tire4Pressure, int tire4age)
        {
            this.model = model;
            this.engine = new Engine(engineSpeed, enginePower);
            this.cargo = new Cargo(cargoWeight, cargoType);
            this.tires = new Tire[4]
            {
                new Tire(tire1Pressure, tire1Age), new Tire(tire2Pressure, tire2Age), new Tire(tire3Pressure, tire3age),
                new Tire(tire4Pressure, tire4age)
            };
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
        }

        public Tire[] Tires
        {
            get { return this.tires; }
        }

        public string Model
        {
            get { return this.model; }
        }

        public Engine Engine
        {
            get { return this.engine; }
        }
    }
}
