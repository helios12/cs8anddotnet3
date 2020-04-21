namespace Excercise02
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double Height
        {
            get { return height; }
            set { height = value; }
        }

        public override double Width
        {
            get { return width; }
            set { width = value; }
        }

        public override double Area
        {
            get 
            {
                return height * width;
            }
        }
    }
}