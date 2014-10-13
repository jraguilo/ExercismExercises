using System;
using System.Collections.Generic;


public class ETL
{
    public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> oldScores)
    {
        Dictionary<string, int> newScores = new Dictionary<string, int>();

        foreach(KeyValuePair<int, IList<string>> score in oldScores)
        {
            int points = score.Key;
            foreach(string item in score.Value)
            {
                newScores.Add(item.ToLower(), points);
            }
        }

        return newScores;
    }
}
