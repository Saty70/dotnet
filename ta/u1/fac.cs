namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            factorial();
        }


        static void factorial()
        {
            int num, n, fac;
            Console.WriteLine("Please enter a number to get its factorial: ");
            n = Convert.ToInt32(Console.ReadLine());
            num = 1;
            fac = 1;
            while (num < n)
            {
                fac = fac * (num+1);
                num++;
            }
            Console.WriteLine("Factorial of {0}! = {1}\n", num, fac);
        }
    }
}using System;

class Factorial
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = CalculateFactorial(number);

        Console.WriteLine("Factorial of " + number + " is: " + factorial);
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        long result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}
