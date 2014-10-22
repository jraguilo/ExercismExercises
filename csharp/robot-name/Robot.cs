using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    public string Name;
    Random _random = new Random((int)DateTime.Now.Ticks);
    public static List<string> names = new List<string>();

    public Robot()
    {
        string newName = "";
        do
        {
            newName = GenerateName();
        }
        while (names.Contains(newName));
        Name = newName;
        names.Add(Name);
    }

    public void Reset()
    {
        string newName;
        do
        {
            newName = GenerateName();
        }
        while(names.Contains(newName));
        names.Remove(Name);
        Name = newName;
        names.Add(Name);
    }

    private string GenerateName()
    {
        StringBuilder builder = new StringBuilder();
        for(int i = 0; i < 5; i++)
        {

            if (i < 2)
                builder.Append(RandomLetter());
            else
                builder.Append(_random.Next(0, 10));
        }
        return builder.ToString();
    }

    private char RandomLetter()
    {
        int num = _random.Next(0, 26);
        char let = (char)('A' + num);
        return let;
    }
}