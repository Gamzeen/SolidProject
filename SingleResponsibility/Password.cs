namespace SingleResponsibility;

public class Password
{
    public void SendNewPassword(string userName)
    {
        Console.WriteLine($"A new password has been sent to the email address associated with {userName}.");
    }
}