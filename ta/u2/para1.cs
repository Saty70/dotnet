using System;

class Multiplier
{
    private int result;

    public Multiplier(int value1, int value2)
    {
        result = value1 * value2;
    }

    public int GetResult()
    {
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int value1 = 5;
        int value2 = 10;

        Multiplier multiplier = new Multiplier(value1, value2);
        int result = multiplier.GetResult();

        Console.WriteLine("The result of multiplying {0} and {1} is: {2}", value1, value2, result);
    }
}
