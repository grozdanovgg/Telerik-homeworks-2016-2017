using System;
class MoonGravity
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int a = number % 7;
        int b = number % 5;

        bool c5 = a == 0;
        bool c7 = b == 0;

        string check = c5 && c7 ? "true" : "false";
        
        Console.WriteLine("{0} {1}", check, number);

    }
}