namespace DependencyInversionPrinciple;

public class Sms :ISender
{
    public void Send()
    {
        Console.WriteLine("Sms gönderildi.");
    }
}