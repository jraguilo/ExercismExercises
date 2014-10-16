using System;


public class Hamming
{
    public static int Compute(string strand1, string strand2)
    {
        if (strand1 == null) throw new ArgumentNullException("Strand 1");
        if (strand2 == null) throw new ArgumentNullException("Strand 2");

        if(strand1.Trim().Length != strand2.Trim().Length)
        {
            throw new ArgumentException("Arguments not of equal length. Can not compute Hamming distance");
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
