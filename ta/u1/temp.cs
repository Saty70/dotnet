using System;

class TemperatureConverter
{
    static void Main()
    {
        // Prompt user for input
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Convert Fahrenheit to Celsius
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Display the result
        Console.WriteLine("Temperature in Celsius: " + celsius);
    }
}
