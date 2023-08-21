namespace SingleResponsibility;

public class Profile
{
    public string GetProfileInformation(string userName)
    {
        // Veritabanından profil bilgilerini çekme işlemi
        return $"Kullanıcı adı: {userName}. Detaylı profil bilgileri burada yer alır.";
    }
}