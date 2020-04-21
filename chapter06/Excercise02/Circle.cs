namespace Excercise02
{
    public class Circle : Shape
    {        
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Height
        {
            get {return radius * 2;}
            set { radius = value / 2; }
        }

        public override double Width
        {
            get {return radius * 2;}
            set { radius = value / 2; }
        }

        public override double Area
        {
            get 
            {
                return System.Math.PI * radius * radius;
            }
        }
    }
}