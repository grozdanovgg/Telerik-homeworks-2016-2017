namespace OOPPrinciplesPart2.Shape
{
    class Square : Shape
    {
        public Square(double side)
        {
            this.height = side;
            this.width = side;
        }
        
        public override double CalculateSurface()
        {
            return this.height * this.width;
        }
    }
}
