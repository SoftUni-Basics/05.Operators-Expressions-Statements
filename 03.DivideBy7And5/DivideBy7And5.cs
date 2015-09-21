/*  Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
 */

using System;

class DivideBy7And5
{
    static void Main()
    {
        string input;
        int value;
        do
        {
            Console.Write("Enter value: ");
            input = Console.ReadLine();
        } while (!int.TryParse(input, out value));

        bool checker = (value % 7 == 0) && (value % 5 == 0);
        Console.WriteLine(checker);
    }
}
