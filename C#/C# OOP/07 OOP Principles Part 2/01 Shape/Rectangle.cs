namespace OOPPrinciplesPart2.Shape
{
    class Rectangle : Shape
    {
        //constructor
        public Rectangle(double a, double b)
        {
            this.width = a;
            this.height = b;
        }

        //methods
        public override double CalculateSurface()
        {
            return this.width * this.height;
        }
    }
}
