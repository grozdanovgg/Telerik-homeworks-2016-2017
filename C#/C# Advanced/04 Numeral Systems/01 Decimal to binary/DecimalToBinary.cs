using System;
using System.Collections.Generic;
using System.Numerics;
class DecimalToBinary
{
    static void Main()
    {

        BigInteger n = BigInteger.Parse(Console.ReadLine());
        //int n = 19;

        List<BigInteger> intList = new List<BigInteger>();


        do
        {
            intList.Add(n % 2);
            n /= 2;
        } while (n > 0);

        intList.Reverse();

        Console.WriteLine(string.Join("", intList));

    }
}