using System;


public class Hamming
{
    public static int Compute(string strand1, string strand2)
    {
        if (string.IsNullOrEmpty(strand1) || string.IsNullOrEmpty(strand2))
        {
            return 0;
        }

        int count = 0;
        
        for(int i = 0; i < strand1.Length && i < strand2.Length; i++)
        {
            if (strand1[i] != strand2[i])
                count++;
        }
        return count;
    }
}
