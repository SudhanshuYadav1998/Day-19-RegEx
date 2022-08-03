using System.Text.RegularExpressions;

class Patterns
{
    public static string RegexRules = "^[abc]{3}[.]*[a-z0-9]*[@][bl]{2}[.][co]{2}[.][a-z]{2}$";
    public bool validateString(string sample)
    {
        return Regex.IsMatch(sample, RegexRules);
    }
}
class program
{
    static void Main(string[] args)
    {
        Patterns patterns = new Patterns();
        if (patterns.validateString("abc.xyz@bl.co.in"))
        {
            Console.WriteLine("Valid");
        }
        else
            Console.WriteLine("Invalid");
    }
}