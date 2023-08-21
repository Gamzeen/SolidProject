namespace InverseToLSP;

public class BBank : IPaymentType
{
    public void TekCekim()
    {
        Console.WriteLine("B Bankası: Tek çekim işlemi gerçekleştirildi.");
    }

    public void KrediKartiTaksitli()
    {
        Console.WriteLine("B Bankası: Kredi kartı taksitli gerçekleştirildi.");
    }

    public void Pay3D()
    {
        Console.WriteLine("B Bankası: 3d güvenlikli çekim işlemi gerçekleştirildi.");
    }
}