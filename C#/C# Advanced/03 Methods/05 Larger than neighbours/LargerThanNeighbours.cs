using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        LargerThan(n, input);
    }
    static void LargerThan(int n, string input)
    {
        string[] inputArr = input.Split(' ');

        int[] intArr = Array.ConvertAll(inputArr, Convert.ToInt32);
        int count = 0;
        for (int i = 1; i < n-1; i++)
        {
            {
                if (intArr[i] > intArr[i - 1] && intArr[i] > intArr[i + 1])
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}
