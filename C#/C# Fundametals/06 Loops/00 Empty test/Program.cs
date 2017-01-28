using System;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal factorial = 1;
        
        while (true)
        {
            if (n == 1)
            {
                break;
            }
            factorial *= n;
            n--;
        }
        Console.WriteLine(factorial);
    }
}