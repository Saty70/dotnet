using System;

class ConversionProgram
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Convert Binary to Decimal");
            Console.WriteLine("2. Convert Decimal to Binary");
            Console.WriteLine("3. Convert Hexadecimal to Octal");
            Console.WriteLine("4. Convert Octal to Decimal");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a binary number: ");
                    string binary = Console.ReadLine();
                    int decimalValue = ConvertBinaryToDecimal(binary);
                    Console.WriteLine("Decimal equivalent: " + decimalValue);
                    break;
                case 2:
                    Console.Write("Enter a decimal number: ");
                    int decimalNumber = Convert.ToInt32(Console.ReadLine());
                    string binaryValue = ConvertDecimalToBinary(decimalNumber);
                    Console.WriteLine("Binary equivalent: " + binaryValue);
                    break;
                case 3:
                    Console.Write("Enter a hexadecimal number: ");
                    string hexadecimal = Console.ReadLine();
                    string octalValue = ConvertHexadecimalToOctal(hexadecimal);
                    Console.WriteLine("Octal equivalent: " + octalValue);
                    break;
                case 4:
                    Console.Write("Enter an octal number: ");
                    string octal = Console.ReadLine();
                    int decimalValueOctal = ConvertOctalToDecimal(octal);
                    Console.WriteLine("Decimal equivalent: " + decimalValueOctal);
                    break;
                case 5:
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
        while (choice != 5);
    }

    static int ConvertBinaryToDecimal(string binary)
    {
        int decimalValue = Convert.ToInt32(binary, 2);
        return decimalValue;
    }

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        string binaryValue = Convert.ToString(decimalNumber, 2);
        return binaryValue;
    }

    static string ConvertHexadecimalToOctal(string hexadecimal)
    {
        string octalValue = Convert.ToString(Convert.ToInt32(hexadecimal, 16), 8);
        return octalValue;
    }

    static int ConvertOctalToDecimal(string octal)
    {
        int decimalValue = Convert.ToInt32(octal, 8);
        return decimalValue;
    }
}
