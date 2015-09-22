/*  Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        ⦁	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        ⦁	Prints on the console the number in reversed order: dcba (in our example 1102).
        ⦁	Puts the last digit in the first position: dabc (in our example 1201).
        ⦁	Exchanges the second and the third digits: acbd (in our example 2101).
    The number has always exactly 4 digits and cannot start with 0.
 */

using System;
using System.Linq;

class FourDigitNumber
{
    static void Main()
    {
        string input;
        int value = 0;
        while (true)
        {
            Console.Write("Enter value: ");
            input = Console.ReadLine().PadLeft(4, '0').Substring(0, 4);
            if (int.TryParse(input, out value) && value > 999)
            {
                break;
            }
            Console.Clear();
        }
        string[] digits = value.ToString().Select(x => x.ToString()).ToArray();
        
        //  Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        int sum = 0;
        foreach (var digit in digits)
        {
            sum += int.Parse(digit);
        }
        Console.WriteLine(sum);

        //  Prints on the console the number in reversed order: dcba (in our example 1102).
        Array.Reverse(digits);
        foreach (var digit in digits)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
        
        //  Puts the last digit in the first position: dabc (in our example 1201).
        Array.Reverse(digits);
        string lastToFirst = digits[3] + (value / 10);
        Console.WriteLine(lastToFirst);

        //  Exchanges the second and the third digits: acbd (in our example 2101).
        string exchanged = digits[0] + digits[2] + digits[1] + digits[3];
        Console.WriteLine(exchanged);
    }
}
