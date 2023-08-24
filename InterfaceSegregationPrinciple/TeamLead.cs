namespace InterfaceSegregationPrinciple;

public class TeamLead : IRecruitment,IMentor, IDevelopment
{
    public void Recruitment()
    {
        Console.WriteLine("TeamLead : The hiring process is being conducted.");
    }

    public void Mentor()
    {
        Console.WriteLine("TeamLead : Mentorship is being provided.");
    }

    public void Development()
    {
        Console.WriteLine("TeamLead : Software development is in progress.");
    }
}