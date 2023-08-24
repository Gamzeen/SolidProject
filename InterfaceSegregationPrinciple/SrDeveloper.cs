namespace InterfaceSegregationPrinciple;

public class SrDeveloper : IMentor, IDevelopment
{
    public void Mentor()
    {
        Console.WriteLine("Sr. Developer: Mentorship is being provided.");
    }

    public void Development()
    {
        Console.WriteLine("Sr. Developer: Software development is in progress.");
    }
}