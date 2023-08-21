namespace InterfaceSegregationPrinciple;

public class SrDeveloper : IMentor, IDevelopment
{
    public void Mentor()
    {
        Console.WriteLine("Sr. Developer: Mentorluk veriliyor.");
    }

    public void Development()
    {
        Console.WriteLine("Sr. Developer: Yazılım geliştirme yapılıyor.");
    }
}