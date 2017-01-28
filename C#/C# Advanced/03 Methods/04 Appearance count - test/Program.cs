using System;
class AppearanceCount
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string inputText = Console.ReadLine();
        int x = int.Parse(Console.ReadLine());
        Appearance(n, x, inputText);
    }
    static void Appearance(int n, int x, string inputText)
    {
        //Input
        string[] input = inputText.Split(' ');
        int[] nums = new int[n];
        int count = 0;
        int countX = 0;

        foreach (var number in input)
        {
            nums[count] = int.Parse(number);
            count++;
        }
        //Magic

        foreach (var item in nums)
        {
            if (item == x)
            {
                countX++;
            }
        }


        //Output
        Console.WriteLine(countX);
    }
}

