using System;
using System.Linq;

//Problem 17. Longest string

//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

class LongestString
{
    static void Main()
    {
        var nameList = new string[] { "peshooo", "tosho", "gosho" };

        var longest = (from str in nameList
                       orderby str.Length descending
                       select str).ToArray()[0];

        Console.WriteLine(longest);
    }
}