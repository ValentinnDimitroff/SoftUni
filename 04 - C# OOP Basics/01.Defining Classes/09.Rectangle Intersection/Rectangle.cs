namespace RectangleIntersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public double Height
        {
            get { return this.height; }
        }
        public double Width
        {
            get { return this.width; }
        }
        public double X
        {
            get { return this.x; }
        }
        public double Y
        {
            get { return this.y; }
        }

        public Rectangle(string id, double width, double height, double topLeftHoriz, double topLeftVert)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = topLeftHoriz;
            this.y = topLeftVert;
        }

        public bool InteresectsWith(Rectangle rectangle)
        {
           if ((this.X <= rectangle.X + rectangle.Width && this.Width + this.X >= rectangle.X)
                && (this.Y <= rectangle.Y + rectangle.Height && this.Y + this.Height > rectangle.Y))
            {
                return true;
            }
            
            return false;
        }
    }
}