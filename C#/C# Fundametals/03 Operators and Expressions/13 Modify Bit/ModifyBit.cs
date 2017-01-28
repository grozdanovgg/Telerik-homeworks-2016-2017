using System;
class ModifyBit
{
    static void Main()
    {
        ulong N = ulong.Parse(Console.ReadLine());
        uint P = uint.Parse(Console.ReadLine());
        sbyte v = sbyte.Parse(Console.ReadLine());

        if (v == 1)
        {
            ulong num = N | (ulong)1 << (int)P;
            Console.WriteLine(num);
        }
        else
        {
            ulong num = N & (ulong)~(1 << (int)P);
            Console.WriteLine(num);
        }
    }
}