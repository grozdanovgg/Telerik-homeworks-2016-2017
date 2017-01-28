using System;
class NumbersFromOneToN
{
    static void Main()
    {
        uint a = uint.Parse(Console.ReadLine());
        uint check = 1;
        while (check <= a)
        {
            Console.Write("{0} ", check);
            check++;
        }
    }
}