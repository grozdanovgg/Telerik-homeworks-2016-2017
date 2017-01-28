using System;
class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int isSeven1 = number / 100;
        int isSeven2 = isSeven1 % 10;

        if (isSeven2 == 7)
        {
            Console.WriteLine("true");
        }
        else
        {

            Console.WriteLine("false {0}", isSeven2);
        }
    }
}