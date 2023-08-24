namespace InverseToLSP;

public class CBank : IPaymentType
{
    public void SinglePayment()
    {
        Console.WriteLine("Bank C: Single payment transaction completed.");
    }

    public void CreditCard()
    {
        Console.WriteLine("Bank C: Credit card transaction completed.");
    }

    public void Pay3D()
    {
        Console.WriteLine("Bank C: 3D secure payment couldn't be processed.");
    }
}