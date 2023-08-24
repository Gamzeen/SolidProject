namespace DependencyInversionPrinciple;

public class Sms :ISender
{
    public void Send()
    {
        Console.WriteLine("An sms has been sent.");
    }
}