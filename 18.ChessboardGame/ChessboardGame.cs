using System;

class ChessboardGame
{
    static void Main()
    {
        int lng = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        
        int blackTeam = 0;
        int whiteTeam = 0;
        int count = 1;

        foreach (var oneChar in input)
        {
            int ch = (int)oneChar;
            bool bigLetters = (ch >= 65 && ch <= 90);
            bool smlLetters = (ch >= 97 && ch <= 122);
            bool digits = (ch >= 48 && ch <= 57);

            if ((count % 2 == 1 && smlLetters) || (count % 2 == 1 && digits))
            {
                blackTeam += ch;
            }
            else if (count % 2 == 1 && bigLetters)
            {
                whiteTeam += ch;
            }
            else if ((count % 2 == 0 && smlLetters) || (count % 2 == 0 && digits))
            {
                whiteTeam += ch;
            }
            else if (count % 2 == 0 && bigLetters)
            {
                blackTeam += ch;
            }
            if (count == (lng*lng))
            {
                break;
            }
            count++;
        }

        if (blackTeam > whiteTeam)
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(blackTeam - whiteTeam);
        }
        else if (whiteTeam > blackTeam)
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(whiteTeam - blackTeam);
        }
        else
        {
            Console.WriteLine("Equal result: {0}", blackTeam);
        }
    }
}