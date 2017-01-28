using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
class BitShiftMatrix
{
    static void Main()
    {
        int rowsCount = int.Parse(Console.ReadLine());
        int colsCount = int.Parse(Console.ReadLine());
        int movesCount = int.Parse(Console.ReadLine());
        List<int> moves = Console
            .ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var visitedMatrix = new bool[rowsCount, colsCount];
        CycleMatrix(visitedMatrix, moves);
        
        BigInteger sum = CalculateMatrix(visitedMatrix);
        Console.WriteLine(sum);
    }

    static BigInteger CalculateMatrix(bool[,] visitedMatrix)
    {
        BigInteger temp = 0;
        BigInteger sum = 0;

        for (int row = 0; row < visitedMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < visitedMatrix.GetLength(1); col++)
            {
                if (visitedMatrix[row,col]==true)
                {
                    temp = ((BigInteger)1 << (visitedMatrix.GetLength(0) - row -1 + col));
                    sum += temp;
                }
            }
        }

        return sum;

    }

    static void CycleMatrix(bool[,] visitedMatrix, List<int> moves)
    {
        int col = 0;
        int row = visitedMatrix.GetLength(0) - 1;
        int coeff = Math.Max(visitedMatrix.GetLength(0), visitedMatrix.GetLength(1));

        foreach (var move in moves)
        {
            int targetRow = move / coeff;
            int targetCol = move % coeff;

            while (col != targetCol)
            {
                visitedMatrix[row, col] = true;
                if (col < targetCol)
                {
                    col++;
                }
                else
                {
                    col--;
                }
            }
            while (row != targetRow)
            {
                visitedMatrix[row, col] = true;
                if (row < targetRow)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }
            visitedMatrix[row, col] = true;

        }
    }
}