/*  Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).
 */

using System;

class PointInACircle
{
    static int count = 0;
    static string[] k = { "X", "Y" };
    static double[] points = new double[2];
    static int questionChecker = 0;
    static bool newPoints = false;

    static void Main()
    {
        while (true)
        {
            if (count < 2)
            {
                points[count] = MakingInput();
                if (questionChecker == 3 && points[count] == double.MinValue)
                {
                    return;
                }
            }
            else if (count == 2)
            {
                bool pointChecker = Math.Sqrt(Math.Pow(points[0], 2) + Math.Pow(points[1], 2)) <= 2;
                Console.WriteLine("\r\n{0}\r\n", pointChecker);
                newPoints = ContinueOrExit();
                if (newPoints)
                {
                    break;
                }
                else
                {
                    AddNewPoint();
                }
            }            
        }
    }
    
    static bool ContinueOrExit()
    {
        Console.WriteLine("Press \"0\" for new point \r\nPress \"9\" to Exit");
        string newPts = Console.ReadLine();
        if (questionChecker == 3)
        {
            return true;
        }
        else if (newPts == "9" || newPts == "0")
        {
            questionChecker = 0;
            if (newPts == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        questionChecker++;
        Console.Clear();
        return ContinueOrExit();
    }

    private static void AddNewPoint()
    {
        questionChecker = 0;
        newPoints = false;
        count = 0;
        Array.Clear(points, 0, points.Length);
        Console.Clear();
    }

    static double MakingInput()
    {
        if (questionChecker == 3)
        {
            return double.MinValue;
        }
        double value;
        Console.Write("Enter value for {0}: ", k[count]);
        string input = Console.ReadLine();
        if ( (double.TryParse(input, out value)) )
        {
            questionChecker = 0;
            count++;
            return value;
        }
        questionChecker++;
        return MakingInput();
    }
}
