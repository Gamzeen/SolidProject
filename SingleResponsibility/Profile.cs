namespace SingleResponsibility;

public class Profile
{
    public void GetProfileInformation(string userName)
    {
        Console.WriteLine($"Username: {userName}. Detailed profile information is presented here.");
    }
}