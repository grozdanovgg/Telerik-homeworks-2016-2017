using System;
using System.Numerics;
class Calculate3
{
    static void Main()
    {
        //  (2*N)! / ((N+1)! * N!)
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger n1 = n + 1;
        BigInteger n2 = n * 2;


        BigInteger c = 0;

        BigInteger fn = 1;
        BigInteger fn2 = 1;
        BigInteger fn1 = 1;

        
        while (n > 0)
        {
            fn *= n;
            n--;
        }
        while (n1 > 0)
        {
            fn1 *= n1;
            n1--;
        }
        while (n2 > 0)
        {
            fn2 *= n2;
            n2--;
        }

        c = fn2 / (fn1 * fn);
        Console.WriteLine(c);
    }
}