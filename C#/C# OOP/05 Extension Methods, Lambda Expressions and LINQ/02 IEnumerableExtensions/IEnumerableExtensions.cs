using System;
using System.Linq;
using System.Collections.Generic;



namespace IEnumerableExtensions
{
    
    //implement the functions: sum, product, min, max, average.
    public static class IEnumerableExtensions
    {
        public static T CustomSum<T>(this IEnumerable<T> numbers)
        {
            dynamic sum = (dynamic)0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
        public static T Product<T>(this IEnumerable<T> numbers)
        {
            dynamic product = (dynamic)1;
            foreach (var number in numbers)
            {
                product *= number;
            }

            return product;
        }
        public static T Minimal<T>(this IEnumerable<T> numbers)
        {
            dynamic minimal = numbers.First();
            foreach (var number in numbers)
            {
                if (number < minimal)
                {
                    minimal = number;
                }
            }
            return minimal;
        }
        public static T Maximal<T>(this IEnumerable<T> numbers)
        {
            dynamic maximal = numbers.First();
            foreach (var number in numbers)
            {
                if (number > maximal)
                {
                    maximal = number;
                }
            }
            return maximal;
        }
        public static T CustomAverage<T>(this IEnumerable<T> numbers)
        {
            dynamic sum = (dynamic)0;
            int count = 0;
            foreach (var number in numbers)
            {
                sum += number;
                count++;
            }
            dynamic average = sum / count;

            return average;
        }
    }
    public static class ExtensionMethods
    {
        ////    Problem 2. IEnumerable extensions
        //      Implement a set of extension methods for IEnumerable<T> that implement
        //      the following group functions: sum, product, min, max, average.

        static IEnumerable<T> Where<T>(this IEnumerable<T> data, Func<T, bool> predicate)
        {
            foreach (T value in data)
            {
                if (predicate(value)) yield return value;
            }
        }
    }
}
