using System;

class BookProblem
{
    static void Main()
    {
        int pagesBook = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int dailyPages = int.Parse(Console.ReadLine());

        if (campingDays == 30 || dailyPages == 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            double months = (double)pagesBook / ((30 - campingDays) * dailyPages);
            double resultYear = months / 12;
            double resultMonths = months % 12;
            Console.WriteLine("{0} years {1} months", Math.Floor(resultYear), Math.Ceiling(resultMonths));
        }
    }
}
