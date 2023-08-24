namespace InterfaceSegregationPrinciple;

public class Recruiter : IWorker
{
    public void Mentor()
    {
        Console.WriteLine("HR: The hiring process is being conducted.");
    }

    public void Recruitment()
    {
        Console.WriteLine("HR: Mentorship is being provided.");
    }

    public void Development()
    {
        Console.WriteLine("HR cannot engage in software development.");
    }
}