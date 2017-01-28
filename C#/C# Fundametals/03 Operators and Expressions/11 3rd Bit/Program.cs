using System;
class Program
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        num = (num >> 3) & 1;
        Console.WriteLine(num);
    }
}