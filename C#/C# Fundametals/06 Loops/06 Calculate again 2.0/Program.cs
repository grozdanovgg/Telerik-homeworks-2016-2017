using System;
using System.Numerics;

class Loops
{
    static void Main(string[] args)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger f = 1;
        for (BigInteger i = n; i > k; i--)
        {
            f = f * i;
        }

        Console.WriteLine(f);
    }
}