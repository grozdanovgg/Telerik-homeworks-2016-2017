using System;
class BinarySearch
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
        int x = int.Parse(Console.ReadLine());

        //initialising variables:
        int min = 0;
        int max = input - 1;
        int middle = (min + max) / 2;

        //Calculation
        //while the nimber is not found && :
        while 
            (
            arr[middle] != x && 
            min <= max //this handles the exeptipn for input = 1
            )
        {
            middle = (min + max) / 2;
            if (arr[middle] < x)
            {
                min = middle + 1;
            }
            else
            {
                max = middle - 1;
            }
        }
        //Print the result
        //Check for exeptions (like input = 1)
        if (arr[middle] != x)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(middle);
        }
    }
}