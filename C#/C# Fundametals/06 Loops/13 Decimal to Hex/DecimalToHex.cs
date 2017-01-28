using System;
class DecimalToHex
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long calc = n;
        long x = 63;
        long hex = 0;

        while (Math.Pow(16, x) > calc)
        {
            x--;
        }

        for (long i = x; i >= 0; i--)
        {
            if (Math.Pow(16, i) > calc)
            {
                Console.Write(0);
            }
            else
            {
                hex = calc / Convert.ToInt64(Math.Pow(16, i));
                calc = calc - hex* Convert.ToInt64(Math.Pow(16, i));
                Console.Write("{0:X}", hex);
            }
        }

    }
}