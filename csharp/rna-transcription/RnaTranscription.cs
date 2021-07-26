using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        char[] dna = { 'A', 'C', 'G', 'T' };
        char[] rna = { 'U', 'G', 'C', 'A' };
        string rnaStrand = "";

        for (int i = 0; i <= nucleotide.Length - 1; i++)
        {
            rnaStrand += rna[Array.IndexOf(dna, nucleotide[i])];
        }

        return rnaStrand;
    }
}