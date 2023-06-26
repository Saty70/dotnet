using System;

class FibonacciSeries
{
    static void Main()
    {
        Console.Write("Enter the number of Fibonacci numbers to generate: ");
        int n = Convert.ToInt32(Console.ReadLine());

        GenerateFibonacciSeries(n);
    }

    static void GenerateFibonacciSeries(int n)
    {
        int first = 0;
        int second = 1;

        Console.WriteLine("Fibonacci Series:");

        if (n >= 1)
        {
            Console.Write(first + " ");
        }

        if (n >= 2)
        {
            Console.Write(second + " ");
        }

        for (int i = 3; i <= n; i++)
        {
            int next = first + second;
            Console.Write(next + " ");

            first = second;
            second = next;
        }

        Console.WriteLine();
    }
}
