namespace Excercise02
{
    public class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double Height
        {
            get { return side; }
            set { side = value; }
        }

        public override double Width
        {
            get { return side; }
            set { side = value; }
        }

        public override double Area
        {
            get
            {
                return side * side;
            }
        }
    }
}