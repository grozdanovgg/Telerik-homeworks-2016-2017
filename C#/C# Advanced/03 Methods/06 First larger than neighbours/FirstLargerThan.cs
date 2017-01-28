using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        FirstLargerThan(n, input);
    }
    static void FirstLargerThan(int n, string input)
    {
        //Cnverting string to int array
        string[] inputArr = input.Split(' ');
        int[] intArr = Array.ConvertAll(inputArr, Convert.ToInt32);

        int count = 0;

        //Magic
        for (int i = 1; i < n - 1; i++)
        {
            if (intArr[i] > intArr[i - 1] && intArr[i] > intArr[i + 1])
            {
                count = i;
                break;
            }
        }
        //Output
        Console.WriteLine(count);
    }
}
