using System;
using System.Collections.Generic;

public class School
{
    public Dictionary<int, List<string>> Roster;

    public School()
    {
        Roster = new Dictionary<int, List<string>>();
    }

    public void Add(string name, int grade)
    {
        if(Roster.ContainsKey(grade))
            Roster[grade].Add(name);
        else
        {
            Roster.Add(grade, new List<string> {name});
        }
        Roster[grade].Sort();
    }

    public List<string> Grade(int grade)
    {
        if (Roster.ContainsKey(grade))
            return Roster[grade];
        return new List<string>();
    }
}
