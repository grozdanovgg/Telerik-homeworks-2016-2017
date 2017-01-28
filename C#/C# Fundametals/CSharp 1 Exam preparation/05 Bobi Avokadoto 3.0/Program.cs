using System;
class BobiAvokadoto3
{
    static void Main()
    {
        uint head = uint.Parse(Console.ReadLine());
        uint numbOfCombs = uint.Parse(Console.ReadLine());

        uint superComb = 0;
        uint combCount = 0;


        for (int i = 0; i < numbOfCombs; i++)
        {
            uint input = uint.Parse(Console.ReadLine());

            //is comb valid
            if ((head & input) == 0)
            {//comb is valid
                //count teeth
                uint comb = 0;
                for (int j = 0; j < 32 && (input >> j) > 0; j++)
                {
                    comb += ((input >> j) & 1);
                }

                //check if best
                if (comb > combCount)
                {
                    combCount = comb;
                    superComb = input;
                }
            }
        }
        Console.WriteLine(superComb);
    }
}
