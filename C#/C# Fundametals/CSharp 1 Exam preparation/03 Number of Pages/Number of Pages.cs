using System;
class NumberofPages
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        
        uint two = 2;
        uint ten = 1;
        long nine = 0;
        long numLen = input.ToString().Length;
        
        for (uint i = 9; i < input; i = (9 * (two++) * (ten *= 10)))
        {
            input -= i;
            nine = (nine * 10) + 9;
        }
        
        Console.WriteLine(nine + (input / numLen));
    }
}