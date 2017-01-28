using System;
using System.Collections.Generic;
using System.Numerics;
class Messages
{
    static List<string> encriptionKeys = new List<string> { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
    static void Main()
    {
        //input
        
        string encriptedLeftNumber = Console.ReadLine();
        string operatorSign = Console.ReadLine();
        string encriptedRightNumber = Console.ReadLine();
        //string encriptedLeftNumber = "markoncykyanogi"; // 56398
        //string operatorSign = "-";                      //   -39
        //string encriptedRightNumber = "cykyan";         // 56359

        //Magic
        BigInteger leftNumber = Decrypt(encriptedLeftNumber);
        BigInteger rightNumber = Decrypt(encriptedRightNumber);
        BigInteger result = FindResult(leftNumber, rightNumber, operatorSign);

        string finalResult = Encrypt(result);
        Console.WriteLine(finalResult);
    }

    static string Encrypt(BigInteger number)
    {
        List<string> digits = new List<string>();
        var numberAsString = number.ToString();
        string stringFromDigits;
        for (int i = 0; i < numberAsString.Length; i++)
        {
            int num1 = numberAsString[i]-'0';
            stringFromDigits = encriptionKeys[num1];

            digits.Add(stringFromDigits);
        }
        stringFromDigits = string.Join("", digits);
        return stringFromDigits;
    }

    static BigInteger FindResult(BigInteger leftNumber, BigInteger rightNumber, string operatorSign)
    {
        BigInteger result = 0;

        switch (operatorSign)
        {
            case "+": result = leftNumber + rightNumber; break;
            case "-": result = leftNumber - rightNumber; break;
            default: result = 0;
                break;
        }

        return result;
    }

    static BigInteger Decrypt(string encriptedLeftNumber)
    {
        List<int> digits = new List<int>();

        for (int i = 0; i < encriptedLeftNumber.Length; i+=3)
        {
            string digitAsString = encriptedLeftNumber.Substring(i, 3);
            digits.Add(encriptionKeys.IndexOf(digitAsString)); // return -1 if there is no such thing, that we search for.
        }

        var digit = BigInteger.Parse(string.Join("", digits));



        return  digit;
    }

}
