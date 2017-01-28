using System;
class BitExchange
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        
        int counter = 3;
        
        for (int i = 24; i <= 26; i++)
        {
            uint checkSmall = (num >> counter) & 1;
            uint checkBig = (num >> i) & 1;
            
            if (checkSmall != checkBig)
            {
                num = num ^ ((uint)1 << counter);
                num = num ^ ((uint)1 << i);
            }
            counter++;
        }
        Console.WriteLine(num);
    }
}