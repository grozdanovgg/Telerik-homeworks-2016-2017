using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        Factorial(n);
    }
    static void Factorial(BigInteger n)
    {

        BigInteger factorial = 1;
        for (BigInteger i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}
