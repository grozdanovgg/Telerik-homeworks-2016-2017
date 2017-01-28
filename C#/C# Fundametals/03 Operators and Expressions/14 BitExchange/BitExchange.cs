using System;
class BitExchange
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());

        uint bit3 = (num >> 3) & 1;
        uint bit4 = (num >> 4) & 1;
        uint bit5 = (num >> 5) & 1;

        uint bit24 = (num >> 24) & 1;
        uint bit25 = (num >> 25) & 1;
        uint bit26 = (num >> 26) & 1;

        uint backup3 = bit3;
        uint backup4 = bit4;
        uint backup5 = bit5;


        // Exchange bit 3 with the value of bit 24
        if (bit24 == 1)
        {
            num = num | 1 << 3;
            if (backup3 == 1)
            {
                num = num | 1 << 24;
            }
            else
            {
                num = num & ~ ((uint)1 << 24);
            }
        }
        else
        {
            num = num & ~((uint)1 << 3);
            if (backup3 == 1)
            {
                num = num | 1 << 24;
            }
            else
            {
                num = num & ~((uint)1 << 24);
            }
        }


        // Exchange bit 4 with the value of bit 25
        if (bit25 == 1)
        {
            num = num | 1 << 4;
            if (backup4 == 1)
            {
                num = num | 1 << 25;
            }
            else
            {
                num = num & ~((uint)1 << 25);
            }
        }
        else
        {
            num = num & ~((uint)1 << 4);
            if (backup4 == 1)
            {
                num = num | 1 << 25;
            }
            else
            {
                num = num & ~((uint)1 << 25);
            }
        }

        // Exchange bit 5 with the value of bit 26
        if (bit26 == 1)
        {
            num = num | 1 << 5;
            if (backup5 == 1)
            {
                num = num | 1 << 26;
            }
            else
            {
                num = num & ~((uint)1 << 26);
            }
        }
        else
        {
            num = num & ~((uint)1 << 5);
            if (backup5 == 1)
            {
                num = num | 1 << 26;
            }
            else
            {
                num = num & ~((uint)1 << 26);
            }
        }
        Console.WriteLine(num);
    }
}