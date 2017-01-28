using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    public class Path
    {
        //fields
        private List<Point3D> points;
        
        //constructor
        public Path()
        {
            this.points = new List<Point3D>();
        }

        //properties
        public List<Point3D> Points { get { return this.points; }  }


        ////METHODS ADD AND REMOVE
        public void AddPointToList(Point3D somePoint)
        {
            this.points.Add(somePoint);
        }
        public void DeletePointFromList(int index)
        {
            this.points.RemoveAt(index);
        }


    }
}
