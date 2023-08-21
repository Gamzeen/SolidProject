using InverseToSRP;

Transactions islemler = new Transactions();
string kullaniciAdi = "example_user";

islemler.SendNewPassword(kullaniciAdi);

double bakiye = islemler.GetBalance(1200);
Console.WriteLine($"Bakiye: {bakiye}");

string profil = islemler.GetProfileInformation(kullaniciAdi);
Console.WriteLine(profil);