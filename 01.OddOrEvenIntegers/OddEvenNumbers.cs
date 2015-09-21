/*  Write an expression that checks if given integer is odd or even.
 */

using System;

class OddEvenNumbers
{
    static void Main()
    {
        string input;
        int number;
        do
        {
            Console.Write("Enter integet value: ");
            input = Console.ReadLine();
        } while (!int.TryParse(input, out number));
        bool checker = number % 2 == 1;
        Console.WriteLine("Number({0}) is Odd?", number);
        Console.WriteLine(checker);
    }
}
