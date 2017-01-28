using System;
class BiggestOf3
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine(a);
        }
        else if (c >= a && b <= c)
        {
            Console.WriteLine(c);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
}