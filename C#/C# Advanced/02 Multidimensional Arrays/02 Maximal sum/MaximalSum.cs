using System;
using System.Linq;

namespace Problem2.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            //Input
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                int[] tempArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = tempArr[col];
                }
                Array.Clear(tempArr, 0, tempArr.Length);
            }

            //Calculations
            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] +
                              matrix[row, col + 1] +
                              matrix[row, col + 2] +
                              matrix[row + 1, col] +
                              matrix[row + 1, col + 1] +
                              matrix[row + 1, col + 2] +
                              matrix[row + 2, col] +
                              matrix[row + 2, col + 1] +
                              matrix[row + 2, col + 2];
                    if (sum > bestSum)
                        bestSum = sum;
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}