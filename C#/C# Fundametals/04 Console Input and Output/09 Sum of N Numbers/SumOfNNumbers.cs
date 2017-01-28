using System;
class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        float f = float.Parse(Console.ReadLine());
        float sum = 0;
        for (int i = 0; i < n - 1; i++)
        {
            sum = float.Parse(Console.ReadLine());
            f += sum;

        }

        Console.WriteLine(f);
    }
}