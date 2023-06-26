using System;

class PalindromeChecker
{
    static bool IsPalindrome(string str)
    {
        // Remove spaces and convert to lowercase for case-insensitive comparison
        str = str.Replace(" ", "").ToLower();

        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false; // Characters don't match, hence not a palindrome
            }

            left++;
            right--;
        }

        return true; // All characters match, it is a palindrome
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }
}
