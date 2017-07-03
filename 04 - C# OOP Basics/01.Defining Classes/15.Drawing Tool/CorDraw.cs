namespace DrawingTool
{
    public class CorDraw
    {
        public Shape shape;

        public CorDraw(Shape shape)
        {
            this.Draw(shape);
        }

        public void Draw(Shape shape)
        {
            shape.Draw();
        }

    }
}
