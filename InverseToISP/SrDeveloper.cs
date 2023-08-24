namespace InterfaceSegregationPrinciple;

public class SrDeveloper : IWorker
{
    public void Mentor()
    {
        Console.WriteLine("Sr. Developer: Mentorship is being provided.");
    }

    public void Recruitment()
    {
        Console.WriteLine("A Senior Developer cannot perform the hiring process.");
    }

    public void Development()
    {
        Console.WriteLine("Sr. Developer: Software development is in progress.");
    }
}