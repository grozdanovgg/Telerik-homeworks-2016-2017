using System;
class FrequentNumber
{
    static void Main(string[] args)
    {
        //Input
        //int input = 7;
        //int[] arr = { 5, 6, 7, 6, 1, 2, 3 };
        int input = int.Parse(Console.ReadLine());
        int[] arr = new int[input];
        for (int index = 0; index < input; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }

        int maxCount = int.MinValue;
        int currentCount = 1;
        int number = 0;

        //Calculation
        //Sorting the array:
        Array.Sort(arr);

        //Already ordered array-comparing numbers one by one:
        for (int i = 1; i < input; i++)
        {
            
            if (arr[i] == arr[i - 1])
            {
                currentCount++;
            }
            else //When counting the first sum, reset the currentCount for the next loop:
            {
                currentCount = 1;
            }
            //Storing the biggest sequence and the Num type that makes it:
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                number = arr[i];
            }
        }

        //Handles the exeption for input = 1:
        if (input == 1)
        {
            maxCount = 1;
            number = arr[0];
        }

        //Printing the result
        Console.WriteLine("{0} ({1} times)", number, maxCount);
        
    }
}