using System;
class Interval
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());

        double count = 0;
        for (double i = n+1; i < m; i++)
        {
            double div = i % 5;
            if (div == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}