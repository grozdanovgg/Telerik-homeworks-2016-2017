using System;
class BitSwap
{
    static void Main()
    {
        //Write a program first reads 4 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} 
        //with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console

        uint n = uint.Parse(Console.ReadLine());
        uint p = uint.Parse(Console.ReadLine());
        uint q = uint.Parse(Console.ReadLine());
        uint k = uint.Parse(Console.ReadLine());

        for (int i = (int)q; i <= q + k - 1; i++)
        {
            uint checkP = (n >> (int)p) & 1;
            uint checkQ = (n >> i) & 1;
            
            if (checkP != checkQ)
            {
                n = n ^ ((uint)1 << (int)p);
                n = n ^ ((uint)1 << i);
            }
            p++;
        }

        Console.WriteLine(n);
    }
}