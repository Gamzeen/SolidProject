namespace InterfaceSegregationPrinciple;

public class Recruiter : IWorker
{
    public void Mentor()
    {
        Console.WriteLine("HR: Mentorluk veriliyor.");
    }

    public void Recruitment()
    {
        Console.WriteLine("HR: İşe alma işlemi gerçekleştiriliyor.");
    }

    public void Development()
    {
        Console.WriteLine("HR Yazılım geliştirme yapamaz.");
    }
}