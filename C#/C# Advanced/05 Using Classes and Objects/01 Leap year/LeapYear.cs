using System;

class StaticMethods
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        bool checkLeap = DateTime.IsLeapYear(input);

        Console.WriteLine(checkLeap ? "Leap": "Common");
    }
}