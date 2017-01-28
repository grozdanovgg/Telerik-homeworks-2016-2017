using System;
class StringsAndObjects
{
    static void Main()
    {
        string str1 = "Hello ";
        string str2 = "World";
        object Together = String.Join(" ", str1, str2);
        Console.WriteLine(Together);
        string third = (string)Together;
    }
}
