using System;
using System.Collections.Generic;

public class DNA
{
    public Dictionary<char, int> NucleotideCounts;

    public DNA(string strand = "")
    {
        NucleotideCounts = new Dictionary<char, int> { { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 } };
        strand = strand.Trim();
        if (strand != "")
        {
            foreach(char nucleotide in strand)
            {
                NucleotideCounts[nucleotide]++;
            }
        }
    }


    public int Count(char nucleotide)
    {
        if (nucleotide != 'A' && nucleotide != 'T' && nucleotide != 'C' && nucleotide != 'G')
            throw new InvalidNucleotideException();
        return NucleotideCounts[nucleotide];
    }
}

public class InvalidNucleotideException : Exception { }
