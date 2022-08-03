using System.Text.RegularExpressions;

class Patterns
{
    public static string Regex_First_Name = "^[A-Z][a-z]{2,}$";
    public bool validateString(string sample)
    {
        return Regex.IsMatch(sample, Regex_First_Name);
    }
}
class program
{
    static void Main(string[] args)
    {
        Patterns patterns = new Patterns();
        if (patterns.validateString("Sudhanshu"))
        {
            Console.WriteLine("Valid");
        }
        else
            Console.WriteLine("Invalid");
    }
}