using System;
class Program
{
    static void Main()
    {
        //Define array
        char[] alphabet = new char[26];
        int o = 0;
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            alphabet[o] = letter;
            o++;
        }
        
        //Input
        string input = Console.ReadLine();
        //string input = "telerikacademy";

        //initialising variables:
        int min = 0;
        int max = alphabet.Length - 1;
        int middle = (min + max) / 2;

        //Calculation
        //while the nimber is not found
        for (int t = 0; t < input.Length; t++)
        {
            for (int i = 0; alphabet[middle] != input[t] && i < alphabet.Length; i++)
            {
                middle = (min + max) / 2;
                if (alphabet[middle] < input[t])
                {
                    min = middle+1;
                }
                else
                {
                    max = middle-1;
                }

            }
            Console.WriteLine(middle);
            min = 0;
            max = alphabet.Length - 1;
        }
        //Printing the result
    }
}
