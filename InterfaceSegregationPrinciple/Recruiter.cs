namespace InterfaceSegregationPrinciple;

public class Recruiter : IMentor, IRecruitment
{
    public void Mentor()
    {
        Console.WriteLine("HR: Mentorluk veriliyor.");
    }

    public void Recruitment()
    {
        Console.WriteLine("HR: İşe alma işlemi gerçekleştiriliyor.");
    }
}