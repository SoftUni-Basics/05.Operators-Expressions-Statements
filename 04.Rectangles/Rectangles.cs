/*  Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter rectangle width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter rectangle height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("Perimeter = {0}", perimeter);
        Console.WriteLine("Area = {0}", area);
    }
}
