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
        bool isAnagram = false;
        if (!candidate.ToLower().Equals(original))
        {
            if (SortString(candidate).Equals(word))
                isAnagram = true;
        }
        return isAnagram;
    }

    private string SortString(string str)
    {
        var chars = str.ToLower().ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}
