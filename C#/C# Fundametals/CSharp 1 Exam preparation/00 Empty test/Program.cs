using System;
class Batman
{
    static void Main()
    {
        //One of the shortest and fastest ways of solving theese kind of problems is by using new string
        //Basically you split the image in N partitions, which are similar and change by algorithm,
        //then in each part you have to find how the lanes changes one after another and use local variables to deal with it
        int sizeOfSign = int.Parse(Console.ReadLine());
        char character = char.Parse(Console.ReadLine());
        //The first part are the wings of the BAT 
        for (int i = 0; i < sizeOfSign / 2 - 1; i++)
        {
            Console.WriteLine("{0}", new string(' ', i));

            Console.WriteLine("{0}", new string(character, sizeOfSign - i));

            Console.WriteLine("{0}", new string(' ', sizeOfSign));

            Console.WriteLine("{0}", new string(character, sizeOfSign - i));

            Console.WriteLine("{0}", new string(' ', i));
        }

    }
}