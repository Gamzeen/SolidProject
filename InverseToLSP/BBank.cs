namespace InverseToLSP;

public class BBank : IPaymentType
{
    public void SinglePayment()
    {
        Console.WriteLine("Bank B: Single payment transaction completed.");
    }

    public void CreditCard()
    {
        Console.WriteLine("Bank B: Credit card transaction completed.");
    }

    public void Pay3D()
    {
        Console.WriteLine("Bank B: 3D secure payment transaction completed.");
    }
}