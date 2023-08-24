namespace LiskovSubstitutionPrinciple;

public class CBank :IPaymentType
{
    public void SinglePayment()
    {
        Console.WriteLine("Bank C: Single payment transaction completed.");
    }

    public void CreditCard()
    {
        Console.WriteLine("Bank C: Credit card transaction completed.");
    }
}