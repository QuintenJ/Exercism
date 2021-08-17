using System;
using System.Linq;
public static class BeerSong
{
    private static string NumberToString(this int number) => number > 0 ? number.ToString() : "No more";
    private static string BottleText(this int number) => number != 1 ? "bottles" : "bottle";
    public static string Recite(int startBottles, int takeDown)
    {
        return string.Join("" + '\n' + '\n',
            Enumerable.Range(0, takeDown)
                      .Select(x => startBottles - x)
                      .Select(b =>
                      {
                          var current = b;
                          var next = b - 1;

                          var verse = $"{current.NumberToString()} {current.BottleText()} of beer on the wall, {current.NumberToString().ToLower()} {current.BottleText()} of beer.\n";

                          verse += (next >= 0) ? $"Take {(current == 1 ? "it" : "one")} down and pass it around, {next.NumberToString().ToLower()} {next.BottleText()} of beer on the wall."
                                               : $"Go to the store and buy some more, 99 {99.BottleText()} of beer on the wall.";

                          return verse;
                      })
                      .ToArray());
    }
}