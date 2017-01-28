using System;
class FormatingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string hexValue = a.ToString("X");
        int binary = 0;
        
        Console.Write("{0} |", hexValue);

        for (int i = 9; i >= 0; i--)
        {
            binary = (a >> i) & 1;
            Console.Write(binary);
        }
        Console.Write("| {0:f2}|", b);
        Console.WriteLine("{0:f3} |", c);

    }
}