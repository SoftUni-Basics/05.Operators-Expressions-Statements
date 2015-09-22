/*  Write an expression that checks for given point (x, y) 
        if it is within the circle K({1, 1}, 1.5) 
        and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */

using System;

class PointInCircleOutOfRectangle
{
    static void Main()
    {
        double circleX = 1, circleY = 1, circleRadius = 1.5;

        Console.Write("Enter value X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter value Y: ");
        double y = double.Parse(Console.ReadLine());

        // vector = distance between Circle(X,Y) - new points(x,y)
        double vector = Math.Sqrt(Math.Pow(circleX - x, 2) + Math.Pow(circleY - y, 2));

        // R(top=1, left=-1, width=6, height=2) - top = rectY1; left = rectX1..
        int rectX1 = -1, rectY1 = 1;
        int rectX2 = rectX1 + 6, rectY2 = rectY1 - 2;

        bool checkX = x >= rectX1 && x <= rectX2;   // if both is true == in rectangle
        bool checkY = y <= rectY1 && y >= rectY2;   //

        if (vector <= circleRadius)
        {
            if (checkX && checkY)
            {
                Console.Write("No\t\t-");
                Console.WriteLine("the point is inside of the rectangle;\t(in circle)\r\n");
            }
            else
            {
                Console.Write("YES\t\t-");
                Console.WriteLine("the point is inside the circle, out of the rectangle.\r\n");
            }
        }
        else
        {
            if (checkX && checkY)
            {
                Console.Write("No\t\t-");
                Console.WriteLine("the point is inside of the rectangle;\t(out circle)\r\n");
            }
            else
            {
                Console.Write("No\t\t-");
                Console.WriteLine("that point is out from both.\r\n");
            }
        }
    }
}