using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animal_hierarchy
{
    class Frog: Animal,ISound
    {
        //constructor
        public Frog(string name, int age, GenderEnum sex) : base(name, age, sex)
        {
        }
        //methods
        public void Talk()
        {
            Console.WriteLine("Qwaak");
        }
    }
}
