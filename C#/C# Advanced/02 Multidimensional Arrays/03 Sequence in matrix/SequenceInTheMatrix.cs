using System;
class SequenceInTheMatrix
{
    static void Main()
    {
        //Input
        int n = 5;
        int m = 5;
        int[,] matrix =
        {
            { 8, 10, 14, 42, 59, 48, 12, 14 },
            { 09, 8, 22, 24, 56, 14, 15, 55 },
            {  5, 63, 8, 46, 34, 95, 14, 11 },
            { 34,  5, 52, 8, 23, 44, 32, 14 },
            { 26, 88,  5, 71,  8, 95, 12, 18 },
            { 25, 34, 16,  5, 39,  8, 52, 73 }
        };
        int col = 0;
        int row = 0;
        int count = 1;
        int maxCount = 1;
        int maxSize = int.MinValue;

        if (n > m)
        {
            maxSize = n;
        }
        else
        {
            maxSize = m;
        }

        //Calculation
        //Compare ROWS
        for (row = 0; row < matrix.GetLength(0); row++)
        {
            for (col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    count++;
                }

            }
        }
        if (maxCount < count)
        {
            maxCount = count;
        }
        count = 1;
        //Compare COLS
        for (col = 0; col < matrix.GetLength(1); col++)
        {
            for (row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    count++;
                }

            }
        }
        if (maxCount < count)
        {
            maxCount = count;
        }
        count = 1;

        //Compare DIAGONALS
        //Diagonal 1: Top Left > Bottom right
        //Top right triangle
        int num1 = 1;

        for (int d = 0; d < matrix.GetLength(0); d++, num1++)
        {
            for (row = 0, col = d; row < matrix.GetLength(0) - num1 || col < matrix.GetLength(1) - num1; row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    count++;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            count = 1;
        }
        //Bottom left triangle
        int num2 = matrix.GetLength(1) - 1;
        for (int y = matrix.GetLength(0)-2; y >0; y--, num2++)
        {
            for (row = y, col = 0; row < matrix.GetLength(0) - 1 || col < matrix.GetLength(0)- num2; row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    count++;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            count = 1;
        }
        //Diagonal 2: Bottom Left > Top right
        //Bottom right triangle
        int num3 = matrix.GetLength(1) - 1;
        for (int t = matrix.GetLength(0) - 2; t > 0; t--, num3++)
        {
            for (row = t, col = matrix.GetLength(1); row > 0 || col >0; row--, col--)
            {
                if (matrix[row, col] == matrix[row - 1, col - 1])
                {
                    count++;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            count = 1;
        }
        // triangle


        //for (int y = matrix.GetLength(0) - 2; y > 0; y--)
        //{
        //    for (row = matrix.GetLength(0) - 2, col = 0; col < num2 || row > 0; col++, row--)
        //    {
        //        if (matrix[row, col] == matrix[row + 1, col + 1])
        //        {
        //            count++;
        //        }
        //    }
        //    num2++;

        //}





        //Return maxCount



        //Printint result

        Console.WriteLine(maxCount);

    }
}
