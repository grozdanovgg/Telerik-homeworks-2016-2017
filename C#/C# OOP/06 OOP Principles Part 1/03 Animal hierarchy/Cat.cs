using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animal_hierarchy
{
    class Cat : Animal, ISound
    {
        public Cat(string name, int age, GenderEnum sex) :base(name, age, sex)
        {
        }

        //methods
        public void Talk()
        {
             Console.WriteLine("Miayy");
        }
    }
}
