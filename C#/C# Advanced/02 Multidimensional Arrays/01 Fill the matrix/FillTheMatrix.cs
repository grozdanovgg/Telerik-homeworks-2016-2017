using System;
class FillTheMatrix
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        char type = char.Parse(Console.ReadLine());

        int row = n;
        int col = n;
        int count = 1;

        int[,] matrix = new int[row, col];

        if (type == 'a')
        {
            for (col = 0; col < matrix.GetLength(0); col++)
            {
                for (row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
        }
        else if (type == 'b')
        {
            for (col = 0; col < matrix.GetLength(0); col++)
            {
                for (row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
                col++;
                for (row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
        }
        else if (type == 'c')
        {

            //Creating jagged arrays:
            int bigCount = 1;
            int L = 2 * n - 1;
            int[][] triangle = new int[L][];

            int newRow = 0;
            int countRow = 1;

            for (row = 0; row < L / 2 + 1; row++)
            {
                triangle[row] = new int[row + 1];
                for (int i = 0; i < row + 1; i++)
                {
                    triangle[row][i] = bigCount;
                    bigCount++;
                }
                newRow = row;
            }
            for (row = newRow + 1; row < L; row++)
            {
                triangle[row] = new int[newRow + 1 - countRow];
                for (int i = 0; i < newRow + 1 - countRow; i++)
                {
                    triangle[row][i] = bigCount;
                    bigCount++;
                }
                countRow++;
            }


            //Creating the matrix from jagged arrays, ready for printing.
            int countCycles = 0;
            int countTriangle = 0;

            for (col = 0; col < matrix.GetLength(0); col++)
            {
                for (row = matrix.GetLength(countCycles) - 1; row >= 0; row--)
                {
                    matrix[row, col] = triangle[countTriangle][col];
                    countTriangle++;
                    //int test1 = triangle[test0].Length-1;
                    //matrix[row, col] = triangle[indexRow][indexCol];
                    //indexRow++;
                }
                countTriangle = 1;
                countTriangle += col;
                countCycles++;
            }




        }
        else if (type == 'd')
        {

        }
    }
}