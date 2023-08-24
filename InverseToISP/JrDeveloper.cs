namespace InterfaceSegregationPrinciple;

public class JrDeveloper : IWorker
{
    public void Mentor()
    {
        Console.WriteLine("A Jr. Developer cannot perform the mentoring process.");
    }

    public void Recruitment()
    {
        Console.WriteLine("A Jr. Developer cannot perform the hiring process.");
    }

    public void Development()
    {
        Console.WriteLine("Jr. Developer: Software development is in progress.");
    }
}