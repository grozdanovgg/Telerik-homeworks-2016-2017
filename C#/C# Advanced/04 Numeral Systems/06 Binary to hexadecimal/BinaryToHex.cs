using System;
using System.Numerics;
class BinaryToHex
{
    static void Main()
    {
        string bistring = Console.ReadLine();

        string hexNum = Convert.ToInt64(bistring, 2).ToString("X");
        
        Console.WriteLine(hexNum);
    }
}