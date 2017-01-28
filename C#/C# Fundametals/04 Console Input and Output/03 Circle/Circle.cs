using System;
class Circle
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double perimeter = r * 2 * Math.PI;
        double area = Math.PI * Math.Pow(r, 2);

        Console.WriteLine("{0:f2} {1:f2}", perimeter, area);
    }
}