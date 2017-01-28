using System;
class Program
{
    static void Main()
    {
        //Input
        int input = int.Parse(Console.ReadLine());
        int[] arr1 = new int[input];
        int[] arr2 = new int[input];
        for (int i = 0; i < input; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < input; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }

        // Calculation
        bool check = true;
        for (int i = 0; i < input ; i++)
        {
            if (arr1[i] != arr2[i])
            {
                check = false;
                break;
            }
            else
            {
                check = true;
            }
        }
        if (check)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");

        }
    }
}
