using System;
class TwoSidesOneAngle
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double degrees = y * Math.PI / 180;
        double sin = Math.Sin(degrees);
        double area = 0;

        area = (a * b * sin) / 2;

        Console.WriteLine("{0:0.00}", area);
    }
}