using System;
class RandomNumbers
{
    static void Main()
    {
        Random r = new Random();
        for (int i = 0; i < 10; i++)
        {
            int rInt = r.Next(0, 100);
            Console.WriteLine(rInt);
        }
        
    }
}