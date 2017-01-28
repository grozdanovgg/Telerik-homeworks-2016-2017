using System;
using System.Collections.Generic;
using System.Numerics;

class Task01
{
    static List<string> encriptionKeys = new List<string> { "hristo", "tosho", "pesho", "hristofor", "vlad", "haralampi", "zoro", "vladimir" };

    static string[] SplitSentenceToWords(string inputSentance)
    {
        string[] splitText = inputSentance.Split(new[] { ", " }, StringSplitOptions.None);
        return splitText;
    }

    static BigInteger DivideWordAndReturnNum(string word)
    {
        //Declaring variables
        string newWord = string.Empty;
        List<int> numbers = new List<int>();
        string numbersString = string.Empty;

        //Some helpful initial numbers
        int wordLength = word.Length;

        for (int i = wordLength - 1; i >= 0; i--)
        {
            newWord = word.Substring(i);

            BigInteger keyIndex = encriptionKeys.IndexOf(newWord);

            if (keyIndex == -1)
            {
                continue;
            }
            else
            {
                numbersString = keyIndex.ToString() + numbersString;
                word = word.Remove(i);
            }

        }
        BigInteger result = BigInteger.Parse(numbersString);
        return result;
    }

    static List<BigInteger> OctalToDecimal(List<BigInteger> octalNums)
    {
        BigInteger result = 0;
        List<BigInteger> listResults = new List<BigInteger>();

        //result = digit + result * 8
        for (int j = 0; j < 4; j++)
        {
            string temp = octalNums[j].ToString();

            for (int i = 0; i < temp.Length; i++)
            {
                temp = octalNums[j].ToString();
                result = (temp[i] - '0') + result * 8;
            }
            listResults.Add(result);
            result = 0;
        }
        return listResults;
    }

    static void Main()
    {
        //Declare variables
        var octalNumbersList = new List<BigInteger>();
        var decimalNumbersList = new List<BigInteger>();

        //Input
        string[] stickedWords = SplitSentenceToWords(Console.ReadLine());

        //Magic
        // 1. Find numerical value in octal numerical system for the the sticked words
        foreach (var word in stickedWords)
        {
            octalNumbersList.Add(DivideWordAndReturnNum(word));
        }
        // 2. Converting octal list to decimal list
        decimalNumbersList = OctalToDecimal(octalNumbersList);
        //Output
        BigInteger result = 1;
        foreach (var number in decimalNumbersList)
        {
            result *= number;
        }
        Console.WriteLine(result);
    }
}