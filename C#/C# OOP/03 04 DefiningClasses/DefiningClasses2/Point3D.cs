using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    public struct Point3D
    {
        //private static readony inital point, that holds coordinates 0,0,0
        private static readonly Point3D initialPoint;

        //properties
        //// static property
        public static Point3D O
        {
            get
            {
                return initialPoint;
            }
        }
        //// non-static properties
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }
        
        //static constructor to define the initial point
        static Point3D()
        {
            initialPoint = new Point3D(0, 0, 0);
        }
        //public constructor to set the point values.
        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return $"{X} {Y} {Z}";
        }
    }
}
