namespace DrawingTool
{
    using System;
    using System.Text;

    public class Square : Shape
    {
        private int side;
        
        public Square(int side)
        {
            this.side = side;
        }

        public override void Draw()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"|{new string('-', this.side)}|");
            for (int i = 0; i < this.side - 2; i++)
            {
                sb.AppendLine($"|{new string(' ', this.side)}|");
            }
            sb.AppendLine($"|{new string('-', this.side)}|");

            Console.WriteLine(sb);
        }
    }
}
