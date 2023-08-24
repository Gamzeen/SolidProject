namespace InverseToLSP;

public interface IPaymentType
{
    void SinglePayment();
    void CreditCard();
    void Pay3D();
}