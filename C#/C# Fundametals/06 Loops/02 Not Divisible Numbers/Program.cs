using System;
class NumbersFromOneToN
{
    static void Main()
    {
        uint a = uint.Parse(Console.ReadLine());
        uint check = 1;
        while (check <= a)
        {
            if (check % 3 != 0 && check % 7 != 0)
                Console.Write("{0} ", check);
            check++;
        }
    }
}