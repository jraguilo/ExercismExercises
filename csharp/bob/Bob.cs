using System.Linq;

public class Bob
{
    public string Hey(string message)
    {
        //No message
        if(string.IsNullOrWhiteSpace(message))
        {
            return "Fine. Be that way!";
        }

        //Message is a yell
        if(message.Any(c => char.IsLetter(c)) && message.ToUpper() == message)
        {
            return "Whoa, chill out!";
        }

        //Message is a question
        if(message.EndsWith("?"))
        {
            return "Sure.";
        }

        //All other messages
        return "Whatever.";
    }

}
