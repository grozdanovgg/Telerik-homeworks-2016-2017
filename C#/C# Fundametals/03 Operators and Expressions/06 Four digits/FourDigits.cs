using System;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        int r;

        //take the last digit:
        int d = num % 10;
        int c = (num / 10) % 10;
        int b = (num / 100) % 10;
        int a = (num / 1000) % 10;

        //01 Sum of the digits:
        while (num != 0)
        {
            r = num % 10;
            num = num / 10;
            sum += r;
        }
        Console.WriteLine(sum);

        //02 dcba:
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);

        //03 dabc:
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);

        //04 acbd:
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);





    }
}