using System;
class BinaryShort
{
    static void Main()
    {
        short input = short.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 15; i >= 0; i--)
        {
            result = (input >> i) & 1;
            Console.Write(result);
        }
    }
}