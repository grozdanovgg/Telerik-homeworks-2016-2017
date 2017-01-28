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
            Console.WriteLine("{0}{1}{2}{3}{4}", new string(' ', i), new string(character, sizeOfSign - i), new string(' ', sizeOfSign),
                new string(character, sizeOfSign - i), new string(' ', i));
        }

        //The second part is the only line which holds the end of the wings + the head of the bat.

        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", new string(' ', sizeOfSign / 2 - 1), new string(character, sizeOfSign / 2 + 2),
            new string(' ', sizeOfSign / 2 - 1), new string(character, 1), new string(' ', 1), new string(character, 1), new string(' ', sizeOfSign / 2 - 1),
            new string(character, sizeOfSign / 2 + 2), new string(' ', sizeOfSign / 2 - 1));

        // The third part is the torso of the bat 
        for (int i = 0; i < sizeOfSign / 3; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string(' ', sizeOfSign / 2), new string(character, sizeOfSign * 2 + 1), new string(' ', sizeOfSign / 2));
        }
        // The last part is the tail
        for (int i = 0, t = 2; i < sizeOfSign / 2; i++, t += 2)
        {
            Console.WriteLine("{0}{1}{2}", new string(' ', (sizeOfSign + 1) + i), new string(character, sizeOfSign - t), new string(' ', (sizeOfSign + 1) + i));
        }

    }
}