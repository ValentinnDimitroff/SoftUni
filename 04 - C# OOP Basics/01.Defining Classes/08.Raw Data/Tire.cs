﻿namespace RawData
{
    public class Tire
    {
        public Tire(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }

        private double pressure;
        private int age;

        public double Pressure
        {
            get { return this.pressure; }
        }
    }
}
