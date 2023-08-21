// See https://aka.ms/new-console-template for more information

using SingleResponsibility;


string kullaniciAdi = "Ayşe Fatma";

Password sifreYenileme = new Password();
sifreYenileme.SendNewPassword(kullaniciAdi);

Balance bakiyeSorgulama = new Balance();
double bakiye = bakiyeSorgulama.GetBalance(1500.00);
Console.WriteLine($"Bakiye: {bakiye}");

Profile profilBilgi = new Profile();
string profil = profilBilgi.GetProfileInformation(kullaniciAdi);
Console.WriteLine(profil);
 
