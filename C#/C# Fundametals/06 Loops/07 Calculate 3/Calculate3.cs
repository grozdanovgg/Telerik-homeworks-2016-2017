using System;
using System.Numerics;
class Calculate3
{
    static void Main()
    {
        //  N! / (K! * (N - K)!)
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger result = 0;
        BigInteger nk = n - k;

        BigInteger fk = 1;
        BigInteger fn = 1;
        BigInteger fnk = 1;


        while (k > 0)
        {
            fk *= k;
            k--;
        }
        while (n > 0)
        {
            fn *= n;
            n--;
        }
        while (nk > 0)
        {
            fnk *= nk;
            nk--;
        }

        result = fn / (fk * fnk);
        Console.WriteLine(result);
    }
}