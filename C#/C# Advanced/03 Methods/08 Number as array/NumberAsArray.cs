using System;
using System.Numerics;
class NumberAsArray
{
    static void Main()
    {   
        string size = Console.ReadLine();
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        //string size = "10 10";
        //string first = "8 3 3 9 9 9 9 9 9 0";
        //string second = "6 2 4 2 9 9 9 9 9 9";
        NumberArray(size, first, second);
    }

    static void NumberArray(string size, string first, string second)
    {
        //Reading the arrays size:
        //string[] sizeArr = size.Split(' ');
        //int size1 = int.Parse(sizeArr[0]);
        //int size2 = int.Parse(sizeArr[1]);

        //Convert input strings to arrays
        string[] firstArr = first.Split(' ');
        string[] secondArr = second.Split(' ');
        Array.Reverse(firstArr);
        Array.Reverse(secondArr);

        //Converting arrays to ints
        uint num1 = uint.Parse(string.Join("", firstArr));
        uint num2 = uint.Parse(string.Join("", secondArr));

        uint num3 = num1 + num2;
        string result = num3.ToString();

        //Reversing the result
        char[] inputarray = result.ToCharArray();
        Array.Reverse(inputarray);
        string output = new string(inputarray);

        int[] finalResult = new int[inputarray.Length];
        for (int i = 0; i < inputarray.Length; i++)
        {
            finalResult[i] = (int)Char.GetNumericValue(inputarray[i]);
        }


        //Printing the result
        //char[] finalResult = output.ToCharArray();
        Console.WriteLine(string.Join(" ", finalResult));
    }
}
