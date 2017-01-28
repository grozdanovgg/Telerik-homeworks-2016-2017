using System;
class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        double perimeter = width * 2 + height * 2;
        Console.WriteLine("{0:f2} {1:f2}", area, perimeter);
    }
}