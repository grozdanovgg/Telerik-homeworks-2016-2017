﻿using System;
class NumbersFrom1ToN
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            int num2 = i;
            Console.WriteLine(num2);
        }
    }
}