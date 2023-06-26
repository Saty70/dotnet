using System;

class PrimeChecker
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        // Check divisibility from 2 to the square root of the number
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false; // Number is divisible, hence not prime
            }
        }

        return true; // Number is prime
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }
}
