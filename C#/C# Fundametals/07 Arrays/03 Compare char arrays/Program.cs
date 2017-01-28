using System;
class Program
{
    static void Main()
    {
        // Input
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();
        int length;
        string result = null;
        if (word1.Length > word2.Length)
        {
            length = word2.Length;
            result = ">";
        }
        else if (word1.Length < word2.Length)
        {
            length = word1.Length;
            result = "<";
        }
        else
        {
            length = word1.Length;
            result = "=";
        }
        char letter1 = word1[0];
        char letter2 = word2[0];
        // Calculation
        for (int i = 0; i < length; i++)
        {
            letter1 = word1[i];
            letter2 = word2[i];

            if (letter1 > letter2)
            {
                result = ">";
                break;

            }
            else if (letter1 < letter2)
            {
                result = "<";
                break;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine(result);
    }
}