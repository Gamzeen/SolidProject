namespace LiskovSubstitutionPrinciple;

public class CBank :IPaymentType
{
    public void TekCekim()
    {
        Console.WriteLine("C Bankası: Tek çekim işlemi gerçekleştirildi.");
    }

    public void KrediKartiTaksitli()
    {
        Console.WriteLine("C Bankası: Kredi kartı taksitli işlemi gerçekleştirildi.");
    }
}