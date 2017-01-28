using System;
class BobiAvocadoto
{
    static void Main(string[] args)
    {
        //Input

        //int head = 17;
        //int numbOfCombs = 3;
        //int[] arr = { 14, 2, 17 };
        uint superComb = 0;
        uint test = 0;
        uint comb = 0;
        bool checkCompatability;


        uint head = uint.Parse(Console.ReadLine());
        uint numbOfCombs = uint.Parse(Console.ReadLine());
        uint[] arr = new uint[numbOfCombs];
        
        for (int i = 0; i < numbOfCombs; i++)
        {
            arr[i] = uint.Parse(Console.ReadLine());
        }

        //Calculation

        //Checj combs one by one:
        for (int i = 0; i < numbOfCombs; i++)
        {
            //Check if comb is compatable:

            checkCompatability = (head & arr[i]) == 0;
            if (checkCompatability)
            {
                //This new number xorNum contains as many 1`s, as are the points recieved by this comb:
                uint xorNum = head ^ arr[i];

                //Counting the numbers of 1`s, so called Points for the comb:
                for (int j = 0; j < 32; j++)
                {
                    test = (xorNum >> j) & 1;
                    comb += test;
                }
                if (superComb < comb)
                {
                    superComb = arr[i];
                    comb = 0;
                }
            }
        }

        //Printing the result
        Console.WriteLine(superComb);

    }
}
