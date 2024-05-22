using System.Net.Mail;
using System.Text.RegularExpressions;
namespace EAV;

public static class ValidatorService
{
    public static bool ValidateEmailByRegex(string emailAddress)
    {
        string regexPattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
        Regex regex = new Regex(regexPattern);
        return regex.IsMatch(emailAddress);
    }

    public static bool ValidateEmailByMailLib(string emailAddress)
    {
        if (MailAddress.TryCreate(emailAddress, out var res))
            return true;
        return false;
    }
}
