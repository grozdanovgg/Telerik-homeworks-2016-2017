using System;
class AddingPolynominals
{
    static void Main()
    {
        //int n = 3;
        //string pol1 = "5 0 1";
        //string pol2 = "7 4 -3";

        int n = int.Parse(Console.ReadLine());
        string pol1 = Console.ReadLine();
        string pol2 = Console.ReadLine();
        PolySum(n, pol1, pol2);

    }

    static void PolySum(int n, string pol1, string pol2)
    {
        string[] arr1 = pol1.Split(' ');
        string[] arr2 = pol2.Split(' ');
        string[] arr3 = new string[n];

        //Convert string arr to int arr
        int[] newArr1 = Array.ConvertAll(arr1, Convert.ToInt32);
        int[] newArr2 = Array.ConvertAll(arr2, Convert.ToInt32);
        int[] newArr3 = Array.ConvertAll(arr3, Convert.ToInt32);

        for (int i = 0; i < n; i++)
        {
            newArr3[i] = newArr1[i] + newArr2[i];
        }

        Console.WriteLine((String.Join(" ", newArr3)));
    }
}
