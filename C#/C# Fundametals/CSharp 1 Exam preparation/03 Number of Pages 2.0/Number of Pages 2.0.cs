using System;
class NumberOfPages2
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 0;
        int count = 0;

        for (int i = 1; b < input; i++)
        {
            a = i.ToString().Length;
            b = b + a;
            count = i;
        }
        Console.WriteLine(count);
    }
}