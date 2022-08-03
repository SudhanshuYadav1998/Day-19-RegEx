using System.Text.RegularExpressions;

class Patterns
{
    public static string RegexRules = "^(?=.*[A-Z])(?=.*[!@#$%&^*?])(?=.*[a-z])(?=.*[0-9]).{8}$";
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
        if (patterns.validateString("A!msdGj0"))
        {
            Console.WriteLine("Valid");
        }
        else
            Console.WriteLine("Invalid");
    }
}