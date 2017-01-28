using System;
class OddOrEven
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());

        if (num1 % 2 == 0)
            Console.WriteLine("even {0}", num1);
        else
        {
            Console.WriteLine("odd {0}", num1);

        }
    }
}