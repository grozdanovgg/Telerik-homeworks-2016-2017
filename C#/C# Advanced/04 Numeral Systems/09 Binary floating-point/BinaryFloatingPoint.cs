using System;
class BinaryFloatingPoint
{
    static void Main()
    {
        float input = float.Parse(Console.ReadLine());

        int bitCount = sizeof(float) * 8; // never rely on your knowledge of the size
        char[] result = new char[bitCount]; // better not use string, to avoid ineffective string concatenation repeated in a loop

        // now, most important thing: (int)value would be "semantic" cast of the same
        // mathematical value (with possible rounding), something we don't want; so:
        int intValue = System.BitConverter.ToInt32(BitConverter.GetBytes(input), 0);

        for (int bit = 0; bit < bitCount; ++bit)
        {
            int maskedValue = intValue & (1 << bit); // this is how shift and mask is done.
            if (maskedValue > 0)
                maskedValue = 1;
            // at this point, masked value is either int 0 or 1
            result[bitCount - bit - 1] = maskedValue.ToString()[0]; // bits go right-to-left in usual Western Arabic-based notation
        }

        //Printing the result
        //Console.WriteLine(result); // string from character array
        char sign = result[0];
        int exponent = 0;
        int mantissa = 0;
        Console.WriteLine("Sign: {0}", sign);
        Console.Write("Exponent: ");

        for (int i = 1; i <= 8; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
        Console.Write("Mantissa: ");
        for(int i = 9; i <= 31; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}