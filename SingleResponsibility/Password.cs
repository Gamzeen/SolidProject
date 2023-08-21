namespace SingleResponsibility;

// Şifre sıfırlama işlemi
public class Password
{
    public void SendNewPassword(string userName)
    {
        // E-posta gönderme işlemi
        Console.WriteLine($"Yeni şifre {userName} e-postası adresine gönderildi.");
    }
}