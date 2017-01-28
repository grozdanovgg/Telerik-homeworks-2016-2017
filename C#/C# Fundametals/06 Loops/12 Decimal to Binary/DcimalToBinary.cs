using System;
class DcimalToBinary
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long calc = n;
        long x = 31;
        while (Math.Pow(2, x) >= calc)
        {
            x--;
        }

        for (long i = x; i >= 0; i--)
        {
            if (Math.Pow(2, i) > calc)
            {
                Console.Write(0);
            }
            else
            {
                Console.Write(1);
                calc = calc - Convert.ToInt64(Math.Pow(2, i));
            }
        }
    }
}
