using System;

class Program
{
    static void PrintPyramid(int num)
    {
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int number;
        while (true)
        {
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid value.");
                continue;
            }
            if (number == 0)
            {
                Console.WriteLine("Closing Program...");
                break;
            }
            else
            {
                Console.WriteLine();
                PrintPyramid(number);
            }
        }
    }
}
