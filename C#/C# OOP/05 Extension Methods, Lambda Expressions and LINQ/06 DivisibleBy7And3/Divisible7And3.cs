using System;
using System.Linq;

namespace DivisibleBy7And3
{
    //Problem 6. Divisible by 7 and 3

    //Write a program that prints from given array of integers all numbers
    //that are divisible by 7 and 3. Use the built-in extension methods
    //and lambda expressions.Rewrite the same with LINQ.
    class Divisible7And3
    {
        static void Main()
        {
            int[] numbers = { 3, 5, 42, 14, 8, 7, 6, 33, 77, 13, 49, 15, 25, 9, 30, 129, 254, 234 };

            var filteredList = Array.FindAll(numbers, i => (i % 3 == 0) && (i % 7 == 0));
            var test = numbers.Where(i => (i % 3 == 0) && (i % 7 == 0));

            var filteredListLINQ =
                from number in numbers
                where number % 3 == 0 && number % 7 == 0
                select number;
            Console.WriteLine("The entire array: ");
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine();

            Console.WriteLine("Filtered using Lambda: ");
            Console.WriteLine(string.Join(" ", filteredList));
            Console.WriteLine();

            Console.WriteLine("Filtered using LINQ: ");
            Console.WriteLine(string.Join(" ", filteredListLINQ));

        }
    }
}
