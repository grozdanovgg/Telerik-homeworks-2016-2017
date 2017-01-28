using System;
class Trapezoids
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area = a + b;
        area *= h;
        area /= 2;


        Console.WriteLine("{0:f7}", area);
    }
}