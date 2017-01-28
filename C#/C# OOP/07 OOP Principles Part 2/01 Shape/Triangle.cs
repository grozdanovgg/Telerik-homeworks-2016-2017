namespace OOPPrinciplesPart2.Shape
{
    class Triangle : Shape
    {
        //constructor

        public Triangle(double a, double height)
        {
            this.width = a;
            this.height = height;
        }

        //methods
        public override double CalculateSurface()
        {
            return (this.width * this.height) / 2;
        }
    }
}
