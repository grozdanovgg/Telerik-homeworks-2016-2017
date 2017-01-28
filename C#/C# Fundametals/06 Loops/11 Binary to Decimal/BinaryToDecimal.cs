using System;
using System.Numerics;
class BinaryToDecimal
{
    static void Main()
    {
        string bin = Console.ReadLine();
        BigInteger num = BigInteger.Parse(bin);
        long L = bin.Length;
        BigInteger sum = 0;

        for (int i = 0; i < L; i++)
        {
            BigInteger lastDigit = num % 10;
            sum = sum + (lastDigit * Convert.ToUInt64(Math.Pow(2, i)));
            num /= 10;

        }
        
        Console.WriteLine(sum);

    }
}
