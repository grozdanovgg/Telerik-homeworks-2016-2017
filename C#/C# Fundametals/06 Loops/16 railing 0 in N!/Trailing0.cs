using System;
using System.Numerics;
class Trailing0
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger calc = n;

        BigInteger fn = 1;
        int z = 0;
        while (calc > 0)
        {
            fn *= calc;
            calc--;
        }

        while (fn % 10 == 0)
        {
            z++;
            fn /= 10;
        }
        Console.WriteLine(z);
    }
}