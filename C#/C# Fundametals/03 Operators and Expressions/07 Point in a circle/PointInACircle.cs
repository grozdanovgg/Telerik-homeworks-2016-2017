using System;
class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        x = Math.Abs(x);
        y = Math.Abs(y);
        double z;


        if (x != 0 && y != 0)
        {
            x = Math.Pow(x, 2);
            y = Math.Pow(y, 2);
            z = Math.Sqrt(x + y);
            if (z <= 2)
            {
                Console.WriteLine("yes {0:f2}", z);
            }
            else
            {
                Console.WriteLine("no {0:f2}", z);

            }
        }
        else
        {
            if (x <= 2 || y <= 2)
            {
                z = x + y;
                Console.WriteLine("yes {0:f2}", z);
            }
            else
            {
                z = x + y;
                Console.WriteLine("no {0:f2}", z);
            }
        }

    }
}
