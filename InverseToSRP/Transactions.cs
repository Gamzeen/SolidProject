namespace InverseToSRP;

public class Transactions
{
    public double GetBalance(double bakiye)
    {
        // Bakiye çekme işlemi
        return bakiye;
    }
    
    public void SendNewPassword(string userName)
    {
        // E-posta gönderme işlemi
        Console.WriteLine($"Yeni şifre {userName} e-postası adresine gönderildi.");
    }
    
    public string GetProfileInformation(string userName)
    {
        // Veritabanından profil bilgilerini çekme işlemi
        return $"Kullanıcı adı: {userName}. Detaylı profil bilgileri burada yer alır.";
    }
}