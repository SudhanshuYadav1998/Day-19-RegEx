using System.Text.RegularExpressions;

class Patterns
{
    public static string RegexRules = "^[1-9]{2}[ ][1-9][0-9]{9}$";
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
        if (patterns.validateString("91 8960606269"))
        {
            Console.WriteLine("Valid");
        }
        else
            Console.WriteLine("Invalid");
    }
}