namespace InterfaceSegregationPrinciple;

public class Recruiter : IMentor, IRecruitment
{
    public void Mentor()
    {
        Console.WriteLine("HR: Mentorship is being provided.");
    }

    public void Recruitment()
    {
        Console.WriteLine("HR: The hiring process is being conducted.");
    }
}