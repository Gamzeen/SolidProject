using SingleResponsibility;

string userName = "Ayşe Fatma";
 
Password password = new Password();
password.SendNewPassword(userName);

Balance balance = new Balance();
balance.GetBalance();

Profile profilInformation = new Profile();
profilInformation.GetProfileInformation(userName);
 
