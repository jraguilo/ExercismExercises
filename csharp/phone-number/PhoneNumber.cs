using System;
using System.Text.RegularExpressions;


public class PhoneNumber
{
    public string Number = "0000000000";
    public string AreaCode = "000";

    public PhoneNumber(string number)
    {
        if (!String.IsNullOrEmpty(number))
        {
            number = Regex.Replace(number, @"[^\d]", "");
            if (number.Length == 10)
            {
                Number = number;
                AreaCode = number.Substring(0, 3);
            }
            else if(number.Length == 11)
            {
                if(number[0] == '1')
                {
                    Number = number.Substring(1);
                    AreaCode = number.Substring(1, 3);
                }
            }
        }
    }

    public override string ToString()
    {
        return string.Format("({0}) {1}-{2}",
            AreaCode,
            Number.Substring(3, 3),
            Number.Substring(6,4));
    }
}
