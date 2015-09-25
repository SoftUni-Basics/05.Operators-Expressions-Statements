/*  Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
    The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.    */

using System;
using System.Text;

class ExtractThirdBit
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
        Console.Write("{0,-28}", "Enter a unsigned integer:");
        int input = int.Parse(Console.ReadLine());
        int bitPosition = 3;
        int mask = 1;

        int result = input & (mask << bitPosition);
        result = result >> bitPosition;

        int thirdBit = (result == 1) ? 1 : 0;

        Console.WriteLine("{0,-25}{1}", "The value to binary", FourBitsColumns(input));
        Console.WriteLine("{0,-25}{1}", "Binary mask position", FourBitsColumns(1 << bitPosition));
        Console.WriteLine("{0,-23}{1}", "The third bit is:", thirdBit);
    }
}
