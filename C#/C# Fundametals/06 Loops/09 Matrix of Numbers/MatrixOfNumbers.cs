using System;
class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int col = 1;

        for (int row = 1; row <= n; row++)
        {
            for (int column = col; column < n + col; column++)
            {
                Console.Write("{0} ", column);
            }
            Console.WriteLine();
            col++;
        }

    }
}