using System;
using System.Linq;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        List<char> results = new List<char>();
        char[] letters = word.ToLower().ToCharArray();

        foreach (char letter in letters)
        {
            // Allow whitespaces and hyphens to appear multiple times
            if (Char.IsWhiteSpace(letter) || letter.Equals('-'))
                continue;

            // Check if the letter appeared already
            if (results.Contains(letter))
                return false;
            else
                results.Add(letter);
        }

        return true;
    }
}
