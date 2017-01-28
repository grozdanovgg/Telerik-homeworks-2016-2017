using System;
class PrimeCheckInfinity
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        if (num1 <= 1)
        {
            Console.WriteLine("false");
        }
        else
        {
            if (num1 == 2)
            {
                Console.WriteLine("true");
            }
            else
            {
                for (int a = 2; a <= num1; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine("false");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("true");
                        break;

                    }
                }
            }

        }
    }
}