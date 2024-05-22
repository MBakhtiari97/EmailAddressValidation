using EAV;
public class Program
{
    public static void Main()
    {
        var invalidEmail = "test.com";
        var validEmail = "test@gmail.com";

        //By Regex
        if (ValidatorService.ValidateEmailByRegex(invalidEmail))
            Console.WriteLine($"{invalidEmail} Is Valid");
        else
            Console.WriteLine($"{invalidEmail} Is Invalid");

        //By Mail Lib
        if (ValidatorService.ValidateEmailByMailLib(validEmail))
            Console.WriteLine($"{validEmail} Is Valid");
        else
            Console.WriteLine($"{validEmail} Is Invalid");
    }
}