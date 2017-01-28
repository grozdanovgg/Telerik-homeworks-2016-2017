using System;

/*
 * 8. Write a program that finds the sequence of maximal sum in given array. 
 * Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan through the elements of the array)?
 */
class SequenceOfMaximalSum
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] arr = new int[input];
        for (int k = 0; k < input; k++)
        {
            arr[k] = int.Parse(Console.ReadLine());
        }

        int maxTemp = int.MinValue;
        int maxEnd = 0;
        int start = 0;
        int startTemp = 0;
        int end = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            maxEnd += arr[i];

            if (arr[i] > maxEnd)
            {
                maxEnd = arr[i];
                startTemp = i;
            }
            if (maxEnd > maxTemp)
            {
                maxTemp = maxEnd;
                start = startTemp;
                end = i;
            }
        }

        Console.WriteLine(maxTemp);
    }
}