namespace InverseToLSP;

public class ABank : IPaymentType
{
    public void TekCekim()
    {
        Console.WriteLine("A Bankası: Tek çekim işlemi gerçekleştirildi.");
    }

    public void KrediKartiTaksitli()
    {
        Console.WriteLine("A Bankası: Kredi kartı taksitli işlemi gerçekleştirildi.");
    }

    public void Pay3D()
    {
        Console.WriteLine("A Bankası: 3d güvenlikli çekim işlemi gerçekleştirildi.");
    }
}