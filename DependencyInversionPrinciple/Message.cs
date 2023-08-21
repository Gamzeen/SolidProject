namespace DependencyInversionPrinciple;

public class Message 
{
    private readonly ISender _sender;

    public Message(ISender sender)
    {
        _sender = sender;
    }

    public void MessageSend()
    {
        _sender.Send();
    }
}