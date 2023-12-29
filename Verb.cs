public class Verb
{
    string infinitive;

    public Verb ()
    {
        infinitive = "";
    }
        bool vbisvalid = false;

    public void validateVerb(string i)
    {
        vbisvalid = true;
        string ending = i.Substring(i.Length -2);
        switch(ending) 
    {
    case "ar":
        Console.WriteLine("Its an AR verb.");
        break;
    case "er":
        Console.WriteLine("Its an ER verb.");
        break;
    case "ir":
        Console.WriteLine("Its an IR verb.");
        break;
    default:
        Console.WriteLine("Not a verb.");
        vbisvalid = false;
        break;
        }
    }

}