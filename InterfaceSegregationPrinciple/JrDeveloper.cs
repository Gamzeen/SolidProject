namespace InterfaceSegregationPrinciple;

public class JrDeveloper : IWorker
{
    public void Mentor()
    {
        Console.WriteLine("Jr. Developer mentörluk verme işlemi yapamaz.");
    }

    public void Recruitment()
    {
        Console.WriteLine("Jr. Developer işe alma işlemi yapamaz.");
    }

    public void Development()
    {
        Console.WriteLine("Jr. Developer: Yazılım geliştirme yapılıyor.");
    }
}