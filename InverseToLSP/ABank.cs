namespace InverseToLSP;

public class ABank : IPaymentType
{
    public void SinglePayment()
    {
        Console.WriteLine("Bank A: Single payment transaction completed.");
    }

    public void CreditCard()
    {
        Console.WriteLine("Bank A: Credit card transaction completed.");
    }

    public void Pay3D()
    {
        Console.WriteLine("Bank A: 3D secure payment transaction completed.");
    }
}