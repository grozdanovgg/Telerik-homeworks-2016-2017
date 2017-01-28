using System;
using System.Collections.Generic;

class Cards
{    
    static void Main()
    {
        string[] dictionary = {
"2c",  "3c",  "4c",  "5c",  "6c",  "7c",  "8c",  "9c",  "Tc",  "Jc",  "Qc",  "Kc",  "Ac",

"2d",  "3d",  "4d",  "5d",  "6d",  "7d",  "8d",  "9d",  "Td",  "Jd",  "Qd",  "Kd",  "Ad",

"2h",  "3h",  "4h",  "5h",  "6h",  "7h",  "8h",  "9h",  "Th",  "Jh",  "Qh",  "Kh",  "Ah",

"2s",  "3s",  "4s",  "5s",  "6s",  "7s",  "8s",  "9s",  "Ts",  "Js",  "Qs",  "Ks",  "As"};
        //Input
        int n = int.Parse(Console.ReadLine());

        List<ulong> handsList = new List<ulong>();
        List<ulong> handsBitWisedList = new List<ulong>();
        for (int i = 0; i < n; i++)
        {
            ulong hand = ulong.Parse(Console.ReadLine());
            handsList.Add(hand);
        }

        //magic
        ulong bitWised = 0;
        ulong xored = 0;
        ulong xoredResult = 0;
        for (int i = 0; i < n-1; i++)
        {
            bitWised = handsList[i] | handsList[i + 1] | bitWised;
        }
        //test odd times repeating
        for (int i = 0; i < n; i++)
        {
            xored = xored ^ handsList[i];
            xoredResult = xored;
        }

        //Output
        var listBits = new List<ulong>();
        List<string> cards = new List<string>();
        if (bitWised == 4503599627370495)
        {
            Console.WriteLine("Full deck");
            //(k >> pos) & 1 
            for (int i = 0; i < 63; i++)
            {
                ulong bit = (xoredResult >> i) & 1;
                if (bit==1)
                {
                    listBits.Add((ulong)i);
                }
               
            }
            foreach (var item in listBits)
            {
                string temp = dictionary[item];
                cards.Add(temp);
            }
            Console.WriteLine(string.Join(" ", cards));
        }

        else
        {
            Console.WriteLine("Wa wa!");
            for (int i = 0; i < 63; i++)
            {
                ulong bit = (xoredResult >> i) & 1;
                if (bit == 1)
                {
                    listBits.Add((ulong)i);
                }

            }
            foreach (var item in listBits)
            {
                string temp = dictionary[item];
                cards.Add(temp);
            }
            Console.WriteLine(string.Join(" ", cards));
        }
    }
}
