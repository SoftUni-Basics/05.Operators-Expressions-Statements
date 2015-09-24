/*  Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
*/

using System;
using System.Text;

class BitsExchange
{
    static string BinFourColumns(uint value)
    {
        StringBuilder strBuild = new StringBuilder();
        string binary = Convert.ToString(value, 2).PadLeft(32, '0');

        for (int b = 0; b < binary.Length; b += 8)
        {
            strBuild.Append(binary.Substring(b, 8)).Append(" ");
        }
        return strBuild.ToString().TrimEnd();
    }
    static void Main()
    {
        Console.WriteLine("{0,-28}", "Enter an unsigned integer:");
        uint number = uint.Parse(Console.ReadLine());
        
        uint mask = 117440568;
        uint bitsForExchange = mask & number;
        uint result = number & (~ mask);

        result |= (bitsForExchange >> 21) | (bitsForExchange << 21);


        Console.WriteLine("{0,-25}{1}", "Number:", BinFourColumns(number));
        Console.WriteLine("{0,-25}{1}", "Binary Result:", BinFourColumns(result));
        Console.WriteLine("{0,-25}{1}", "Decimal Result:", result);
    }
}

/*
        1140867093	        1107312677
        255406592	        137966136
        4294901775	        4194238527
        5351	            67114183
        2369124121	        2335569705
        
 */