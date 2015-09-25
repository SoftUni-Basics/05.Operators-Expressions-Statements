/*  We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
*/

using System;
using System.Text;

class ModifyABit
{
    static string FourBitsColumns(int value)
    {
        StringBuilder strBuild = new StringBuilder();
        string binary = Convert.ToString(value, 2).PadLeft(32, '0');

        for (int b = 0; b < binary.Length; b += 4)
        {
            strBuild.Append(binary.Substring(b, 4)).Append(" ");
        }
        return strBuild.ToString().TrimEnd();
    }

    static void Main()
    {
        Console.Write("{0,-23}", "Enter a Number:");
        int number = int.Parse(Console.ReadLine());

        Console.Write("{0,-23}", "Enter a Bit position:");
        int bitPosition = int.Parse(Console.ReadLine());

        Console.Write("{0,-23}", "Enter a Bit Value:");
        int bitValue = int.Parse(Console.ReadLine());

        int mask = 1;
        int result = 0;
        bool bitChecker = ((number >> bitPosition) & mask) == 1 ? true : false;

        if (bitValue == 1 && !bitChecker)
        {
            mask <<= bitPosition;
            result = mask | number;
        }
        else if (bitChecker && bitValue == 0)
        {
            mask = ~(mask << bitPosition);
            result = mask & number;
        }
        else
        {
            result = number;
        }

        Console.WriteLine("{0,-25}{1}", "The value to binary", FourBitsColumns(number));
        Console.WriteLine("{0,-25}{1}", "Binary mask position", FourBitsColumns(mask));
        Console.WriteLine("{0,-25}{1}", "Binary result: ", FourBitsColumns(result));
        Console.WriteLine("{0,-23}{1}", "Result:", result);
    }
}
