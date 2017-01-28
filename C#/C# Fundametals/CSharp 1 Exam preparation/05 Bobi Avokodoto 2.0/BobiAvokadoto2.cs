using System;
class BobiAvokadoto2
{
    static void Main(string[] args)
    {
        //Input

        //Reading from the console:
        uint head = uint.Parse(Console.ReadLine());
        uint numbOfCombs = uint.Parse(Console.ReadLine());

        //Initialisation if variables:
        uint superComb = 0;
        uint combCount = 0;



        for (int i = 0; i < numbOfCombs; i++)
        {
            uint input = uint.Parse(Console.ReadLine());

            //
            //Calculation:
            //Check if comb is compatable:

            if ((head & input) == 0)
            {
                uint comb = 0;

                //Counting the numbers of 1`s, representing the Points for the comb:
                for (int j = 0; j < 32; j++)
                {

                    comb += (input >> j) & 1;
                }
                // Evaluating the best comb
                if (combCount < comb)
                {
                    combCount = comb;
                    superComb = input;

                    comb = 0;
                }
            }
        }
        //Printing the result
        Console.WriteLine(superComb);
    }
}