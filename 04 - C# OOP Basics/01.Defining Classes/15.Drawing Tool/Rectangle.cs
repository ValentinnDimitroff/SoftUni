namespace DrawingTool
{
    using System;
    using System.Text;

    public class Rectangle : Shape
    {
        private int width;
        private int length;

        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        public override void Draw()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"|{new string('-', this.width)}|");
            for (int i = 0; i < this.length - 2; i++)
            {
                sb.AppendLine($"|{new string(' ', this.width)}|");
            }
            sb.AppendLine($"|{new string('-', this.width)}|");

            Console.WriteLine(sb);
        }
    }
}
