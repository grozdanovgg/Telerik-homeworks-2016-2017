using System;
class PrintADeck
{
    static void Main()
    {
        char card = char.Parse(Console.ReadLine());

        string type1 = "spades";
        string type2 = "clubs";
        string type3 = "hearts";
        string type4 = "diamonds";

        int num = 0;

        switch (card)
        {

            case '2': num = 2; break;
            case '3': num = 3; break;
            case '4': num = 4; break;
            case '5': num = 5; break;
            case '6': num = 6; break;
            case '7': num = 7; break;
            case '8': num = 8; break;
            case '9': num = 9; break;
            case 'T': num = 10; break;
            case 'J': num = 11; break;
            case 'Q': num = 12; break;
            case 'K': num = 13; break;
            case 'A': num = 14; break;
            default:
                Console.WriteLine("error");
                break;
        }
        if (num >= 2)
        {
            if (num >= 10)
            {
                for (int i = 2; i <= 10; i++)
                {
                    Console.Write("{0} of {1}, ", i, type1);
                    Console.Write("{0} of {1}, ", i, type2);
                    Console.Write("{0} of {1}, ", i, type3);
                    Console.WriteLine("{0} of {1} ", i, type4);
                }
            }
            else
            {
                for (int i = 2; i <= num; i++)
                {
                    Console.Write("{0} of {1}, ", i, type1);
                    Console.Write("{0} of {1}, ", i, type2);
                    Console.Write("{0} of {1}, ", i, type3);
                    Console.WriteLine("{0} of {1} ", i, type4);
                }
            }
        }

       
        if (num >= 11)
        {
            Console.Write("J of {0}, ", type1);
            Console.Write("J of {0}, ", type2);
            Console.Write("J of {0}, ", type3);
            Console.WriteLine("J of {0} ", type4);
        }
        if (num >= 12)
        {
            Console.Write("Q of {0}, ", type1);
            Console.Write("Q of {0}, ", type2);
            Console.Write("Q of {0}, ", type3);
            Console.WriteLine("Q of {0} ", type4);

        }
        if (num >= 13)
        {
            Console.Write("K of {0}, ", type1);
            Console.Write("K of {0}, ", type2);
            Console.Write("K of {0}, ", type3);
            Console.WriteLine("K of {0} ", type4);

        }
        if (num == 14)
        {
            Console.Write("A of {0}, ", type1);
            Console.Write("A of {0}, ", type2);
            Console.Write("A of {0}, ", type3);
            Console.WriteLine("A of {0} ", type4);

        }
    }
}
