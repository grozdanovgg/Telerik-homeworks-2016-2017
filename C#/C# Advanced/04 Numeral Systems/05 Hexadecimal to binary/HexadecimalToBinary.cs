using System;
class HexadecimalToBinary
{
    static void Main()
    {
        string hexstring = Console.ReadLine();

        string biNum = Convert.ToString(Convert.ToInt64(hexstring, 16), 2);


        Console.WriteLine(biNum);

    }
}