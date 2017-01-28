using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class LearnEnglish
    {
        static void Main()
        {
            var DictionaryBG = new List<string>();
            var DictionaryEN = new List<string>();

            DictionaryBG.Add("кофа");
            DictionaryEN.Add("bucket");
            DictionaryBG.Add("тест");
            DictionaryEN.Add("test");
            DictionaryBG.Add("котка");
            DictionaryEN.Add("cat");
            DictionaryBG.Add("куче");
            DictionaryEN.Add("dog");

            Random rnd = new Random();
            int wordPosition = rnd.Next(0, 3);
            string input = String.Empty;
            do
            {
                wordPosition = rnd.Next(0, 3);

                string bgWord = DictionaryBG[wordPosition];
                string enWord = DictionaryEN[wordPosition];

                Console.WriteLine("What this word mean?");
                Console.WriteLine(DictionaryBG[wordPosition]);
                input = Console.ReadLine();
                Console.WriteLine();


                if (input == DictionaryEN[wordPosition])
                {
                    Console.WriteLine("Congratulations, you are right!");
                }
                else
                {
                    while (input != DictionaryEN[wordPosition])
                    {
                        Console.WriteLine("Nope, try again");
                        Console.WriteLine("What this word mean?");
                        Console.WriteLine(DictionaryBG[wordPosition]);
                        Console.WriteLine();
                        input = Console.ReadLine();
                    }
                    Console.WriteLine("Congratulations, you are right!");
                    Console.WriteLine();

                }

            } while (input == DictionaryEN[wordPosition]);
        }
    }
}
