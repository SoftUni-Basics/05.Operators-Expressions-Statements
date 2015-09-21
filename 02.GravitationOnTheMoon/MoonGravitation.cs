/*  The gravitational field of the Moon is approximately 17% of that on the Earth. 
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */

using System;

class MoonGravitation
{
    static void Main()
    {
        string input;
        double value;
        do
        {
            Console.Write("Enter value: ");
            input = Console.ReadLine();
        } while (!double.TryParse(input, out value));
        double result = value * 0.17;
        Console.WriteLine(result);
    }
}
