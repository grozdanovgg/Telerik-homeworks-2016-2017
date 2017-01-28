using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        //Input
        int input = int.Parse(Console.ReadLine());
        int biggestKNum = int.Parse(Console.ReadLine());
        int[] arr = new int[input];
        for (int i = 0; i < input; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int result = 0;


        //Calculation

        //Using Bubble sorting method "biggestKNum"times" to put the biggest numbers in the end of the array
        for (int i = 0; i <= biggestKNum; i++)
        {
            for (int j = 1; j < input; j++)
            {
                if (arr[j - 1] > arr[j])
                {
                    int c = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = c;
                }
            }
        }
        //Calculating the sum of the last elements
        for (int i = input - biggestKNum; i < input ; i++)
        {
            result += arr[i];
        }


        //Printing the result
        Console.WriteLine(result);
    }
}