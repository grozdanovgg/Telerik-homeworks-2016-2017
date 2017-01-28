using System;
class MMSA
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        double input = 0;

        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0;
        double average = 0;
        if (n > 1)
        {
            for (int i = 1; i <= n; i++)
            {
                input = double.Parse(Console.ReadLine());

                if (max < input)
                    max = input;
                else if (min > input)
                    min = input;
                sum += input;
                average = sum / n;
            }
            Console.WriteLine("min={0:f2}", min);
            Console.WriteLine("max={0:f2}", max);
            Console.WriteLine("sum={0:f2}", sum);
            Console.WriteLine("avg={0:f2}", average);
        }
        else
        {
            input = double.Parse(Console.ReadLine());
            Console.WriteLine("min={0:f2}", input);
            Console.WriteLine("max={0:f2}", input);
            Console.WriteLine("sum={0:f2}", input);
            Console.WriteLine("avg={0:f2}", input);
        }


    }
}