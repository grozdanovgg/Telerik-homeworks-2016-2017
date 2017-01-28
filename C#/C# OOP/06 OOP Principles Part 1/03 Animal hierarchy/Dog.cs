using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animal_hierarchy
{
    public class Dog : Animal, ISound
    {
        //constructor
        public Dog(string name, int age, GenderEnum sex) : base(name, age, sex)
        {
        }
        //methods
        public void Talk()
        {
            Console.WriteLine("Bau");
        }
    }
}
