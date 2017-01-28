using System;
class Program
{
    static void Main()
    {

        string input = "-26 -25 -28 31 2 27";
        string[] inputArr = input.Split(' ');
        int[] intArr = Array.ConvertAll(inputArr, Convert.ToInt32);
        //int[] intArr = Array.ConvertAll(inputArr, s => int.Parse(s));
        //int[] intArr = Array.ConvertAll(inputArr, int.Parse);



    }
}
