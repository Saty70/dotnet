using System;
using System.Collections.Generic;

class VowelFinder
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        List<char> vowels = FindUniqueVowels(input);

        Console.WriteLine("Unique vowels in the string: " + string.Join("", vowels));
    }

    static List<char> FindUniqueVowels(string str)
    {
        HashSet<char> vowelSet = new HashSet<char>();
        List<char> uniqueVowels = new List<char>();

        foreach (char c in str)
        {
            if (IsVowel(c) && !vowelSet.Contains(c))
            {
                vowelSet.Add(c);
                uniqueVowels.Add(c);
            }
        }

        return uniqueVowels;
    }

    static bool IsVowel(char c)
    {
        c = char.ToLower(c);

        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
