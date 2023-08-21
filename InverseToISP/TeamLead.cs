namespace InterfaceSegregationPrinciple;

public class TeamLead : IWorker
{
    public void Mentor()
    {
        Console.WriteLine("TeamLead : Mentorluk veriliyor.");
    }

    public void Recruitment()
    {
        Console.WriteLine("TeamLead : İşe alma işlemi gerçekleştiriliyor.");
    }

    public void Development()
    {
        Console.WriteLine("TeamLead : Yazılım geliştirme yapılıyor.");
    }
}