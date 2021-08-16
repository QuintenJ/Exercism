using System;
using System.Linq;
public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand) => firstStrand.Length != secondStrand.Length ? throw new ArgumentException("The length of strings are not equal.") : firstStrand.Where((l, i) => secondStrand[i] != l).Count();
}