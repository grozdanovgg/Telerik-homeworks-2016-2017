using System;
class Program
{
    static void Main()
    {
        //Input
        int input = int.Parse(Console.ReadLine());
        int[] arr = new int[input];
        for (int k = 0; k < input; k++)
        {
            arr[k] = int.Parse(Console.ReadLine());
        }

        //Calculation
        //Selection sort
        /* arr[0] to arr[n-1] is the array to sort */        
        for (int j = 0; j < input - 1; j++)
        {
            /* find the min element in the unsorted a[j .. n-1] */
            /* assume the min is the first element */
            int iMin = j;
            /* test against elements after j to find the smallest */
            for (int i = j + 1; i < input; i++)
            {
                /* if this element is less, then it is the new minimum */
                if (arr[i] < arr[iMin])
                {
                    /* found new minimum; remember its index */
                    iMin = i;
                }
            }

            if (iMin != j)
            {
                int c = arr[j];
                arr[j] = arr[iMin];
                arr[iMin] = c;
            }
        }


        //Printing the result
        for (int o = 0; o < input; o++)
        {
            Console.WriteLine(arr[o]);
        }
    }
}
