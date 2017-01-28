using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.IO;

namespace Arrays
{
    class IndexOfLetters
    {
        static void Main()
        {
            int[] unsortedArray = ReadArray();
            int[] sortedArray = SplitArray(unsortedArray);
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine("{0}", sortedArray[i]);
            }
        }

        static int[] ReadArray()
        {
            int size = int.Parse(Console.ReadLine());
            int[] unsortedArray = new int[size];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = int.Parse(Console.ReadLine());
            }
            return unsortedArray;
        }

        static int[] SplitArray(int[] unsorted)
        {
            if (unsorted.Length == 1)
            {
                return unsorted;
            }
            int half = unsorted.Length / 2;
            int[] leftHalf = new int[half];
            int[] rightHalf = new int[unsorted.Length - half];
            for (int i = 0; i < leftHalf.Length; i++)
            {
                leftHalf[i] = unsorted[i];
            }
            for (int i = 0, j = leftHalf.Length; i < rightHalf.Length; i++, j++)
            {
                rightHalf[i] = unsorted[j];
            }
            leftHalf = SplitArray(leftHalf);
            rightHalf = SplitArray(rightHalf);
            int[] sortedArray = MergeArrays(leftHalf, rightHalf);
            return sortedArray;
        }

        static int[] MergeArrays(int[] firstArray, int[] secondArray)
        {
            int[] array = new int[firstArray.Length + secondArray.Length];
            int firstPos = 0; int secondPos = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((secondPos == secondArray.Length) && (firstPos == firstArray.Length))
                {
                    return array;
                }
                if ((secondPos < secondArray.Length && firstPos < firstArray.Length) && (firstArray[firstPos] <= secondArray[secondPos]) || secondPos == secondArray.Length)
                {
                    array[i] = firstArray[firstPos];
                    firstPos++;
                }
                else if ((firstPos < firstArray.Length && secondPos < secondArray.Length) && (secondArray[secondPos] < firstArray[firstPos]) || firstPos == firstArray.Length)
                {
                    array[i] = secondArray[secondPos];
                    secondPos++;
                }
            }
            return array;
        }
    }
}
