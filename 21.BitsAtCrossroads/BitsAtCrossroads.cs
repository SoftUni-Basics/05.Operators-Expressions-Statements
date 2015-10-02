using System;
using System.Linq;

class BitsAtCrossroads
{
    static void FillTheMatrix(int size, int[,] matrix, int[] numbers)
    {
        int row = numbers[0];
        int col = numbers[1];
        while (row >= 0 && col >= 0)
        {
            PointChecker(matrix, row, col);
            row--; col--;
        }

        row = numbers[0];
        col = numbers[1];
        while (--row >= 0 && ++col < size)
        {
            PointChecker(matrix, row, col);
        }

        row = numbers[0];
        col = numbers[1];
        while (++row < size && ++col < size)
        {
            PointChecker(matrix, row, col);
        }

        row = numbers[0];
        col = numbers[1];
        while (++row < size && --col >= 0)
        {
            PointChecker(matrix, row, col);
        }
    }

    static void PointChecker(int[,] matrix, int row, int col)
    {
        if (matrix[row, col] == 1)
        {
            crossroads++;
        }
        else
        {
            matrix[row, col] = 1;
        }
    }

    static int crossroads = 0;

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];

        while (true)
        {
            string input = Console.ReadLine();
            int[] numbers = new int[2];

            if (input == "end")
            {
                break;
            }
            else
            {
                numbers = input.Split(' ').Select(int.Parse).ToArray();
            }
            crossroads++;
            FillTheMatrix(size, matrix, numbers);
        }

        string[] binary = new string[size];
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = matrix.GetLength(1) - 1; c >= 0; c--)
            {
                binary[r] += matrix[r, c].ToString();
            }
        }
        uint[] outResult = new uint[size];
        for (int i = 0; i < outResult.Length; i++)
        {
            outResult[i] = Convert.ToUInt32(binary[i], 2);
            Console.WriteLine(outResult[i]);
        }
        Console.WriteLine(crossroads);
    }
}
