﻿namespace ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetSurfaceArea()
        {
            var surface = 2 * this.height * this.length + 2 * this.height * this.width + 2 * this.width * this.length;

            return surface;
        }
        public double GetLateralSurfaceArea()
        {
            return 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double GetVolume()
        {
            return this.height * this.width * this.length;
        }
    }
}
