using System;
using System.Numerics;
class IntegerCalculations
{
    static void Main()
    {
        //Print their minimum, maximum, average, sum and product
        //Each on a new line
        //The average value should be printed with two digits of precision
        
        string input = Console.ReadLine();

        Console.WriteLine("{0}", Minimum(input));
        Console.WriteLine("{0}", Maximum(input));
        Console.WriteLine("{0:F2}", Average(input));
        Console.WriteLine("{0}", Sum(input));
        Console.WriteLine("{0}", Product(input));
    }
    static int Minimum(string input)
    {
        string[] array = input.Split(' ');
        int[] newarr = Array.ConvertAll(array, Convert.ToInt32);
        int countMin = int.MaxValue;
        foreach (var item in newarr)
        {
            if (item < countMin)
            {
                countMin = item;
            }
        }
        return countMin;
    }
    static int Maximum(string input)
    {
        string[] array = input.Split(' ');
        int[] newarr = Array.ConvertAll(array, Convert.ToInt32);
        int countMax = int.MinValue;
        foreach (var item in newarr)
        {
            if (item > countMax)
            {
                countMax = item;
            }
        }
        return countMax;

    }
    static float Average(string input)
    {
        string[] array = input.Split(' ');
        float[] newarr = Array.ConvertAll(array, Convert.ToSingle);
        float average = 0;
        float count = 0;

        foreach (var item in newarr)
        {
            count += item;
        }
        average = count / 5;
        return average;
    }
    static int Sum(string input)
    {
        string[] array = input.Split(' ');
        int[] newarr = Array.ConvertAll(array, Convert.ToInt32);
        int sum = 0;
        foreach (var item in newarr)
        {

            sum +=item;

        }
        return sum;

    }
    static BigInteger Product(string input)
    {
        string[] array = input.Split(' ');
        int[] newarr = Array.ConvertAll(array, Convert.ToInt32);
        BigInteger product = 1;
        foreach (var item in newarr)
        {

            product *= item;

        }
        return product;

    }
}
