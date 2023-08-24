namespace DependencyInversionPrinciple;

public class Email :ISender
{
    public void Send()
    {
        Console.WriteLine("An email has been sent.");
    }
}