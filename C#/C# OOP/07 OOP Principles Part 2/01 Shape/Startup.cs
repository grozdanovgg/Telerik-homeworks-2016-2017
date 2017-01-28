using System;
using System.Collections.Generic;

namespace OOPPrinciplesPart2.Shape
{
    class Startup
    {
        static void Main()
        {
            var shapes = new List<Shape> { new Square(5.12), new Triangle(3, 2), new Rectangle(4, 5.6) };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Area of {0}: {1}",shape.GetType().Name, shape.CalculateSurface());
            }
        } 
    }   
}
