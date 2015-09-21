/*  Write an expression that checks for given integer if its third digit from right-to-left is 7.
 */

using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Enter value: ");
        int input = int.Parse(Console.ReadLine());
        input /= 100;
        Console.WriteLine(input % 10 == 7);
    }
}
