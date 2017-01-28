using System;
class FibonacciNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());

        double a = 1;
        double b = 0;
        double c = 0;
        Console.Write("0");

        for (double i = 0; i < n - 1; i++)
        {

            c = a + b;
            a = b;
            b = c;
            Console.Write(", {0}", c);
        }
        Console.WriteLine();
    }
}