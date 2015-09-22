/*  Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
    (i.e. it is divisible without remainder only to itself and 1).
 */

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int value = TakeInput();
        bool isPrime = false;

        if (2 <= value && value <= 100)
        {
            for (int i = 2; i <= value; i++)
            {
                if (value % i == 0 && i < value)
                {
                    break;
                }
                else if (value == i)
                {
                    isPrime = true;
                }
            }
        }
        Console.WriteLine("{0}\r\n", isPrime);
    }

    static int TakeInput()
    {
        int value;
        string input;
        while (true)
        {
            Console.WriteLine("Enter integet between 0 and 100");
            input = Console.ReadLine();
            bool checkInt = int.TryParse(input, out value);
            if (checkInt)
            {
                break;
            }
            Console.Clear();
        }
        return value;
    }
}
