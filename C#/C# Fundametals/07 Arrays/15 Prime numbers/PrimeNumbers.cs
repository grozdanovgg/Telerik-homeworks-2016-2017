using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        bool[] bigArr = new bool[input];
        for (int i = 0; i < bigArr.Length; i++)
        {
            bigArr[i] = true;
        }
        for (int i = 2; i < Math.Sqrt(bigArr.Length); i++)
        {
            if (bigArr[i])
            {
                for (int j = i * i; j < bigArr.Length; j = j + i)
                {
                    bigArr[j] = false;
                }
            }
        }
        int prime = 0;
        for (int i = 0; i < bigArr.Length; i++)
        {
            if (bigArr[i])
            {
                prime = i;
            }
        }
        Console.Write(prime);
    }
}