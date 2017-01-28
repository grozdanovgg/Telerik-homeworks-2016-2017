using System;
class Program
{
    static void Main()
    {
        int n = Console.Read();

        if (n < 0)
        {
            if ((n % 2) == 0 && (n % 3) == 0 && (n % 5) == 0 && (n % 7) == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}