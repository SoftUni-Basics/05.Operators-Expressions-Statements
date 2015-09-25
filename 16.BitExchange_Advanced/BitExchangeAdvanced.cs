/*  Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap.
 */

using System;
using System.Text;

class BitExchangeAdvanced
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
    private static void GetInputValues()
    {
        Console.Write("{0,-28}", "Enter an unsigned integer:");
        string input = Console.ReadLine();
        bigNumb = uint.TryParse(input, out number);

        for (int i = 0; i < 2; i++)
        {
            Console.Write("{0,-16}{1,4}: ", "Enter value for ", (char)(112 + i));
            pos[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(pos);

        Console.Write("{0,-16}{1,4}: ", "Enter value for ", "k");
        maskLng = int.Parse(Console.ReadLine());
    }

    static int[] pos = new int[2];
    static uint number = 0;
    static int maskLng = 0;
    static bool overlapping = (pos[0] + (maskLng - 1)) >= pos[1];
    static bool outOfRange = pos[1] + (maskLng - 1) > 31;
    static bool bigNumb = false;

    static void Main()
    {
        GetInputValues();

        if (!bigNumb)
        {
            Console.WriteLine("out of range");
            return;
        }
        if ((pos[0] + (maskLng - 1)) >= pos[1])
        {
            Console.WriteLine("overlapping");
            return;
        }
        if (pos[1] + (maskLng - 1) > 31)
        {
            Console.WriteLine("out of range");
            return;
        }

        uint addBit = 1;
        uint mask = 0;

        for (int i = 0; i < pos.Length; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                if (j >= pos[i] && j <= pos[i] + (maskLng - 1))
                {
                    mask |= addBit << j;
                }
            }
        }

        uint bitsForExchange = mask & number;
        uint result = number & (~mask);

        result |= ((bitsForExchange >> pos[1]) << pos[0]) | ((bitsForExchange >> pos[0]) << pos[1]);

        Console.WriteLine("{0,-25}{1}", "Number:", ByteColumns(number));
        Console.WriteLine("{0,-25}{1}", "Binary Result:", ByteColumns(result));
        Console.WriteLine("{0,-25}{1}", "Decimal Result:", result);
    }
}
