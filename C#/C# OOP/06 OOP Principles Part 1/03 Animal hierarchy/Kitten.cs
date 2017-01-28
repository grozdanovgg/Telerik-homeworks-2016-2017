using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animal_hierarchy
{
    class Kitten :Cat, ISound
    {
        public Kitten(string name, int age) : base(name, age, GenderEnum.Female)
        {
            
        }
    }
}
