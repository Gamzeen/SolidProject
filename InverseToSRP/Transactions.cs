namespace InverseToSRP;

public class Transactions
{
    public void GetBalance()
    {
        var balance = 150.0;
        Console.WriteLine($"This user has this {balance}.");
    }
    
    public void SendNewPassword(string userName)
    {
        Console.WriteLine($"A new password has been sent to the email address associated with {userName}.");
    }
    
    public void GetProfileInformation(string userName)
    {
        Console.WriteLine($"Username: {userName}. Detailed profile information is presented here.");
    }
}