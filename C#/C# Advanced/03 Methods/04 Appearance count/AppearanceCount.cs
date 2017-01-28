using System;
class AppearanceCount
{
    static void Main()
    {
        Appearance();
    }
    static void Appearance( )
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[n];
        int count = 0;
        int countX = 0;

        foreach (var number in input)
        {
            nums[count] = int.Parse(number);
            count++;
        }
        int x = int.Parse(Console.ReadLine());
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

