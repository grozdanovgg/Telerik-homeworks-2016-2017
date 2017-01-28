using System;
class SortinArray
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();



        SortArray(input);

    }
    static void SortArray(string input)
    {
        string[] array = input.Split(' ');
        int[] newArr = Array.ConvertAll(array, Convert.ToInt32);
        Array.Sort(newArr);

        Console.WriteLine(string.Join(" ", newArr));
    }

}
