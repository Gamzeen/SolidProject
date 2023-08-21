namespace DependencyInversionPrinciple;

public class Email :ISender
{
    public void Send()
    {
        Console.WriteLine("E-posta gönderildi.");
    }
}