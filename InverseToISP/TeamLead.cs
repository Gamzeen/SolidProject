namespace InterfaceSegregationPrinciple;

public class TeamLead : IWorker
{
    public void Mentor()
    {
        Console.WriteLine("TeamLead : Mentorship is being provided.");
    }

    public void Recruitment()
    {
        Console.WriteLine("TeamLead : The hiring process is being conducted.");
    }

    public void Development()
    {
        Console.WriteLine("TeamLead : Software development is in progress.");
    }
}