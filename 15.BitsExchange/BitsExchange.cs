/*  Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
*/

using System;
using System.Text;

class BitsExchange
{
    static string ByteColumns(uint value)
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

        uint mask = 117440568;                  // bin mask --> 00000111 00000000 00000000 00111000
        uint bitsForExchange = mask & number;   // take all bits
        uint result = number & (~ mask);        // remake 3,4,5 and 24,25,26 pos to zeros

        result |= (bitsForExchange >> 21) | (bitsForExchange << 21);  
        /*moving big bits to low position, low bits just disappear.. it's same for low to high position; example: (1 >> 1) */

        Console.WriteLine("{0,-25}{1}", "Number:", ByteColumns(number));
        Console.WriteLine("{0,-25}{1}", "Binary Result:", ByteColumns(result));
        Console.WriteLine("{0,-25}{1}", "Decimal Result:", result);
    }
}
