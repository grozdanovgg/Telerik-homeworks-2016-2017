using System;
class MoonGravity
{
    static void Main()
    {
        float EarthWeight = float.Parse(Console.ReadLine());
        float Percent = 0.17f;
        float MoonWeight = Percent * EarthWeight;
        Console.WriteLine(MoonWeight.ToString("0.000"));
    }
}