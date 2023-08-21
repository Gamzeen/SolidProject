namespace InterfaceSegregationPrinciple;

public class SrDeveloper : IWorker
{
    public void Mentor()
    {
        Console.WriteLine("Sr. Developer: Mentorluk veriliyor.");
    }

    public void Recruitment()
    {
        Console.WriteLine("Sr. Yazılımcı işe alma yapamaz.");
    }

    public void Development()
    {
        Console.WriteLine("Sr. Developer: Yazılım geliştirme yapılıyor.");
    }
}