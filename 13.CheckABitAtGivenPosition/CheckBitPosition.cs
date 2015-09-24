/*  Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1.
*/

using System;
using System.Text;

class CheckBitPosition
{
    static string BinFourColumns(int value)
    {
        StringBuilder strBuild = new StringBuilder();
        string binary = Convert.ToString(value, 2).PadLeft(16, '0');

        for (int b = 0; b < binary.Length; b += 4)
        {
            strBuild.Append(binary.Substring(b, 4)).Append(" ");
        }
        return strBuild.ToString().TrimEnd();
    }

    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        int input = int.Parse(Console.ReadLine());
        Console.Write("Enter a Bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());
        int mask = 1;

        int result = (input >> bitPosition) & mask;

        bool bitChecker = (result == 1) ? true : false;

        Console.WriteLine("{0,-25}{1}", "The value to binary", BinFourColumns(input));
        Console.WriteLine("{0,-25}{1}", "Binary mask position", BinFourColumns(1 << bitPosition));
        Console.WriteLine("Result: {0,22}", bitChecker);
    }
}