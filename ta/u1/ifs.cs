using System;

class ConditionalsDemo
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // If-else ladder
        if (number > 0)
        {
            Console.WriteLine("Number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Number is negative.");
        }
        else
        {
            Console.WriteLine("Number is zero.");
        }

        // Switch statement
        switch (number)
        {
            case 0:
                Console.WriteLine("Number is zero.");
                break;
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Number is between 1 and 3.");
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Number is between 4 and 6.");
                break;
            default:
                Console.WriteLine("Number is greater than 6.");
                break;
        }
    }
}
