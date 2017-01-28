using System;
class Program
{
    static void Main()
    {
        //Input
        int input = int.Parse(Console.ReadLine());
        int[] arr = new int[input];
        for (int i = 0; i < input; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int num = 1;
        int result = 1;
        int final = 1;
        //Calculation

        for (int i = input; i > 1; i--)
        {
            if (arr[i-1] == arr[i - 2])
            {
                num++;
                if (result > num)
                {
                    final = result;
                }
                else
                {
                    result = num;
                    final = result;

                }
            }
            else
            {
                num = 1;
                continue;
            }

        }

        //Print

        Console.WriteLine(final);

    }
}
