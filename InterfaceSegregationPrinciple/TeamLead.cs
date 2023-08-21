namespace InterfaceSegregationPrinciple;

public class TeamLead : IRecruitment,IMentor, IDevelopment
{
    public void Recruitment()
    {
        Console.WriteLine("TeamLead : İşe alma işlemi gerçekleştiriliyor.");
    }

    public void Mentor()
    {
        Console.WriteLine("TeamLead : Mentorluk veriliyor.");
    }

    public void Development()
    {
        Console.WriteLine("TeamLead : Yazılım geliştirme yapılıyor.");
    }
}