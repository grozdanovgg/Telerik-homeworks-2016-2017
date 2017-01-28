using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animal_hierarchy
{
    public class Animal
    {
        //properties
        internal string Name { get; set; }
        internal int Age { get; set; }
        internal GenderEnum Sex { get; set; }

        //constructor
        public Animal(string name, int age, GenderEnum sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
}
