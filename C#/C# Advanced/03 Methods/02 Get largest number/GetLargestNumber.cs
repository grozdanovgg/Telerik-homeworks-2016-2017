using System;
class GetLargestNumber
{
    static void Main()
    {
        string input = Console.ReadLine();


    }
    static void GetMax(string input)
    {
        int max = int.MinValue;
        string[] arr = input.Split(' ');

        foreach (var number in arr)
        {
            if (max < int.Parse(number))
            {
                max = int.Parse(number);
            }
        }
        Console.WriteLine(max);
    }
}
