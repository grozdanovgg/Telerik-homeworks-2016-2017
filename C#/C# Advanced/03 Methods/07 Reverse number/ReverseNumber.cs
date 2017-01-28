using System;
class ReverseNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        ReverseN(input);
    }
    static void ReverseN(string input)
    {
        char[] array = input.ToCharArray();

        Array.Reverse(array);
        Console.WriteLine(array);
    }
}
