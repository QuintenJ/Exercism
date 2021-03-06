using System;
using System.Collections.Generic;
using System.Linq;
public static class ScrabbleScore
{
    private static readonly IDictionary<char, int> letterValues = new Dictionary<char, int>()
    {
        {'A', 1}, {'B', 3}, {'C', 3}, {'D', 2}, {'E', 1},
        {'F', 4}, {'G', 2}, {'H', 4}, {'I', 1}, {'J', 8},
        {'K', 5}, {'L', 1}, {'M', 3}, {'N', 1}, {'O', 1},
        {'P', 3}, {'Q', 10}, {'R', 1}, {'S', 1}, {'T', 1},
        {'U', 1}, {'V', 4}, {'W', 4}, {'X', 8}, {'Y', 4}, {'Z', 10}
    };
    public static int Score(string input) => input.ToUpper().Sum(letter => LetterScore(letter));
    public static int LetterScore(char letter) => letterValues.ContainsKey(letter) ? letterValues[letter] : 0;
}
