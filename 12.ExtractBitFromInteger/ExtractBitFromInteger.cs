/*  Write an expression that extracts from given integer n the value of given bit at index p.
*/

using System;
using System.Text;

class ExtractBitFromInteger
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

        int bitChecker = (result == 1) ? 1 : 0;

        Console.WriteLine("{0,-25}{1}", "The value to binary", BinFourColumns(input));
        Console.WriteLine("{0,-25}{1}", "Binary mask position", BinFourColumns(1 << bitPosition));
        Console.WriteLine("Result: {0,16}", bitChecker);
    }
}
