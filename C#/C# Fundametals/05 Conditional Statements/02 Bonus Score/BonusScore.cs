using System;
class BonusScore
{
    static void Main()
    {
        //If the score is between 1 and 3, the program multiplies it by 10.
        //If the score is between 4 and 6, the program multiplies it by 100.
        //If the score is between 7 and 9, the program multiplies it by 1000.
        //If the score is less than 0 or more than 9, the program prints "invalid score".

        int input = int.Parse(Console.ReadLine());
        int result = input;

        if (0 < input && input < 4)
        {
            result = input * 10;
        }
        else if (3 < input && input < 7 )
        {
            result = input * 100;
        }
        else if (6 < input && input < 10)
        {
            result = input * 1000;
        }
        else
        {
            Console.WriteLine("invalid score");
            return;
        }
        
        Console.WriteLine(result);
    }
}