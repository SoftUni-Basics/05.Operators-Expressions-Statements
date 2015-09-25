/*  Write an expression that extracts from given integer n the value of given bit at index p.
*/

using System;
using System.Text;

class ExtractBitFromInteger
{
    static string FourBitsColumns(int value)
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
        Console.Write("{0,-28}", "Enter an unsigned integer:");
        int input = int.Parse(Console.ReadLine());
        Console.Write("{0,-28}", "Enter a Bit position:");
        int bitPosition = int.Parse(Console.ReadLine());
        int mask = 1;

        int result = (input >> bitPosition) & mask;

        int bitChecker = (result == 1) ? 1 : 0;

        Console.WriteLine("{0,-25}{1}", "The value to binary", FourBitsColumns(input));
        Console.WriteLine("{0,-25}{1}", "Binary mask position", FourBitsColumns(1 << bitPosition));
        Console.WriteLine("{0,-28}{1}", "Result:", bitChecker);
    }
}
