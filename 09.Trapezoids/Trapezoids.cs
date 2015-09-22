/*  Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter value for A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value for B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value for H: ");
        double h = double.Parse(Console.ReadLine());

        //  area = ( (a+b)/2 ) * h
        double area = ((a + b) / 2) * h;
        Console.WriteLine("\r\n Trapezoid area = {0}\r\n", area);
    }
}
