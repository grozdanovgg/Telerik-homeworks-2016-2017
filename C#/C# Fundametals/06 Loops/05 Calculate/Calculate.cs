using System;
class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double s = 0;

        double temp = 0;

        double factorial = 1;


        for (double i = 1; i <= n; i++)
        {
            temp = (factorial *= i) / Math.Pow(x, i);
            s += temp;

        }

        Console.WriteLine("{0:f5}", s + 1);

    }
}