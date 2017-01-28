using System;
class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] num = new int[input];


        for (int i = 0; i < input; i++)
        {
            num[i] = i*5;
        }


        foreach (var result in num)
        {
            Console.WriteLine(result);
        }
    }
}
