using System;

class PrintTheASCIITable
{
    static void Main()
    {
        //33-126

        for (int numANCII = 33; numANCII < 127; numANCII++)
        {
            char AllChar = Convert.ToChar(numANCII);
            Console.Write(AllChar);
        }
    }
}