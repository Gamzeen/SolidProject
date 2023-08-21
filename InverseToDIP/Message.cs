namespace InverseToDIP;

public class Message
{
    public void SendMessage(string type)
    {
        var email = new Email();
        var sms = new Sms();

        if (type =="Email")
        {
            email.Send();
        }
        if (type =="Sms")
        {
            sms.Send();
        }
    }
}