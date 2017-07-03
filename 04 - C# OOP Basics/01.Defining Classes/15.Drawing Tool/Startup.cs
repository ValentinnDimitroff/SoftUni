namespace DrawingTool
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var shapeType = Console.ReadLine();
            Shape shape;

            if (shapeType == "Square")
            {
                var side = int.Parse(Console.ReadLine());
                shape = new Square(side);
            }
            else
            {
                var width = int.Parse(Console.ReadLine());
                var length = int.Parse(Console.ReadLine());
                shape = new Rectangle(width, length);
            }

            var drawer = new CorDraw(shape);
        }
    }
}