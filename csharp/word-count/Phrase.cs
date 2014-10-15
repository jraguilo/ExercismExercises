using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Phrase
{
    public string sentence;

    public Phrase(string sentence)
    {
        sentence = sentence.ToLower();
        this.sentence = Regex.Replace(sentence, @"[^\w']+", " ");
    }

    public Dictionary<string, int> WordCount()
    {
        var counts = new Dictionary<string, int>();
        string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                if (!String.IsNullOrEmpty(word))
                {

                    if (counts.ContainsKey(word))
                        counts[word]++;
                    else
                        counts[word] = 1;
                }
            }
        return counts;
    }
}