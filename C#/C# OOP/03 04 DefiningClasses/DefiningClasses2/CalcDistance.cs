using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    class CalcDistanceIn3D
    {
        //Write a static class with a static method to calculate the 
        //distance between two points in the 3D space.
        public static double CalcDistance(Point3D p1, Point3D p2)
        {
            double result = double.MinValue;

            double magic = Math.Pow((p1.X - p2.X), 2) + 
                Math.Pow((p1.Y - p2.Y), 2) + 
                Math.Pow((p1.Z - p2.Z), 2);

            return result = Math.Sqrt(magic);
        }
    }
}
