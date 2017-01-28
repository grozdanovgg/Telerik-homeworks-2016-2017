using System;
class Buses
{
    static void Main()
    {
        int c = int.Parse(Console.ReadLine());
        int sFirst = int.Parse(Console.ReadLine());
        int s = 0;
        int count = 0;

        for (int i = 1; i < c; i++)
        {
            if (c > 1)
            {
                s = int.Parse(Console.ReadLine());
                
                if (sFirst >= s)
                {
                    count++;
                    sFirst = s;
                }

            }

        }

        Console.WriteLine(count + 1);
    }
}