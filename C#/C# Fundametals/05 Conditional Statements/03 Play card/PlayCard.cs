using System;
class PlayCard
{
    static void Main()
    {
        int numBuffer;
        string input = Console.ReadLine();
        bool check = int.TryParse(input, out numBuffer);

        if (check)
        {
            int num = int.Parse(input);
            if (num > 1 && num < 11)
            {
                Console.WriteLine("yes {0}", num);
            }
            else
            {
                Console.WriteLine("no {0}", num);
            }
        }
        else
        {
            switch (input)
            {
                case "A":
                case "J":
                case "Q":
                case "K": Console.WriteLine("yes {0}", input); break;
                default:
                    Console.WriteLine("no {0}", input);
                    break;
            }
        }
    }
}