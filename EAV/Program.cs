using System.Net.Mail;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main()
    {
        var invalidEmail = "test.com";
        var validEmail = "test@gmail.com";

        if (ValidateEmail(invalidEmail))
            Console.WriteLine($"{invalidEmail} Is Valid");
        else
            Console.WriteLine($"{invalidEmail} Is Invalid");

        if (ValidateEmail(validEmail))
            Console.WriteLine($"{validEmail} Is Valid");
        else
            Console.WriteLine($"{validEmail} Is Invalid");
    }

    //First Approach
    public static bool ValidateEmail(string emailAddress)
    {
        string regexPattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
        Regex regex = new Regex(regexPattern);
        return regex.IsMatch(emailAddress);
    }

    //Second Approach
    //public static bool ValidateEmail(string emailAddress)
    //{
    //    if (MailAddress.TryCreate(emailAddress, out var res))
    //        return true;
    //    return false;
    //}
}
