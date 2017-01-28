using System;
using System.Collections.Generic;

namespace IEnumerableExtensions
{
    class IEnumerableExtensionsTest
    {
        static void Main()
        {

            //2. IEnumerables test
            List<int> list = new List<int>();
            int counter = 7;
            while (counter > 0)
            {
                list.Add(counter);
                counter--;
            }

            Console.WriteLine("Elements are: ");
            foreach (var element in list)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            int sum = list.CustomSum();
            Console.WriteLine($"Sum of Elements in our collection is: {sum}");

            int product = list.Product();
            Console.WriteLine($"Product of Elements in our collection is: {product}");

            int min = list.Minimal();
            Console.WriteLine($"The smallest element in our collection is: {min}");

            int max = list.Maximal();
            Console.WriteLine($"The biggest elemen in our collection is: {max}");

            int average = list.CustomAverage();
            Console.WriteLine($"The biggest elemen in our collection is: {average}");

        }
    }
}
