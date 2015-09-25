using System;

class KingOfThieves
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        for (int i = 0; i < input/2; i++)
        {
            int count = (input/2) - i;
            Console.WriteLine("{0}{1}{0}", new string('-', count), new string(symbol, (i * 2) + 1));
        }
        Console.WriteLine(new string(symbol, input));
        for (int i = 1; i <= input/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', i), new string(symbol, (input - (i * 2))));
        }
    }
}
