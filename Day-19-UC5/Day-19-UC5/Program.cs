using System.Text.RegularExpressions;

class Patterns
{
    public static string RegexRules = "^[a-zA-Z]{8}$";
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
        if (patterns.validateString("asdfghjk"))
        {
            Console.WriteLine("Valid");
        }
        else
            Console.WriteLine("Invalid");
    }
}