using System;
using System.Text;

namespace StringBuilderSubstring
{
    class StringBuilderExtensionsTest
    {
        static void Main()
        {
            int index = 5;
            int length = 12;
            var sentence = new StringBuilder("This is just some text to test the functionality of the extension");
            Console.WriteLine("This is the original sencence:");
            Console.WriteLine(sentence);
            Console.WriteLine();

            var substringedSentance = sentence.Substring(index, length);
            Console.WriteLine($"This is the substring sencence with cut at index: {index} and lenght: {length}");
            Console.WriteLine(substringedSentance);
            Console.WriteLine();
        }
    }
}
