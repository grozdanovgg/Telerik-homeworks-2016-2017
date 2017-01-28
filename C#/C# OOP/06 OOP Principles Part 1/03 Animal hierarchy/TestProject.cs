using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animal_hierarchy
{
    class TestProject
    {
        static void Main()
        {
            //Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define 
            //useful constructors and methods. Dogs, frogs and cats are Animals. 
            //All animals can produce sound (specified by the ISound interface). 
            //Kittens and tomcats are cats. All animals are described by age, name and sex. 
            //Kittens can be only female and tomcats can be only male. Each animal 
            //produces a specific sound.
            //Create arrays of different kinds of animals and calculate the 
            //average age of each kind of animal using a static method (you may use LINQ).

            Kitten myKittie = new Kitten("Keti", 2);
            Console.WriteLine($"Name: {myKittie.Name}, gender: {myKittie.Sex}");
            myKittie.Talk();
            Console.WriteLine();

            Tomcat maleCat = new Tomcat("Koceto", 6);
            Console.WriteLine($"Name: {maleCat.Name}, gender: {maleCat.Sex}");
            maleCat.Talk();
            Console.WriteLine();

            Dog myDog = new Dog("Barkey", 4, GenderEnum.Male);
            Console.WriteLine($"Name: {myDog.Name}, gender: {myDog.Sex}");
            myDog.Talk();
            Console.WriteLine();


            Dog[] dogs =
            {
                new Dog("Sharo",2,GenderEnum.Male),
                new Dog("Bochko",5, GenderEnum.Male),
                new Dog("Pencho", 1, GenderEnum.Male)
            };

            Frog[] frogs =
            {
                new Frog("Conka", 1, GenderEnum.Female),
                new Frog("Kochka", 2, GenderEnum.Female),
                new Frog("Torko", 3, GenderEnum.Male)
            };

            Cat[] cats =
            {
                new Kitten("Kititu", 4),
                new Tomcat("Tomas", 5)
            };

            Console.WriteLine("Average age of dogs: {0:f2}", AverageAge(dogs));
            Console.WriteLine("Average age of frogs: {0:f2}", AverageAge(frogs));
            Console.WriteLine("Average age of cats: {0:f2}", AverageAge(cats));

        }
        static double AverageAge(Animal[] animals)
        {
            double sumOfAges = 0.00;

            foreach (var animal in animals)
            {
                sumOfAges += animal.Age;
            }

            double averageAge = sumOfAges / animals.Length;

            return averageAge;
        }



    }
}

