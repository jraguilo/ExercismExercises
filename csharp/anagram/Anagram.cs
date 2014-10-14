using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Anagram
{
    private string original;
    private string word;

    public Anagram(string word)
    {
        original = word;
        this.word = SortString(word);
    }

    public string[] Match(string[] candidates)
    {
        var anagrams = new SortedSet<string>();
        foreach(string candidate in candidates)
        {
            if (DetectAnagram(candidate))
                anagrams.Add(candidate);
        }
        return anagrams.ToArray();
    }

    private bool DetectAnagram(string candidate)
    {
        if (candidate.ToLower().Equals(original))
            return false;
        if (SortString(candidate).Equals(word))
            return true;
        return false;
    }

    private string SortString(string str)
    {
        var chars = str.ToLower().ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}
