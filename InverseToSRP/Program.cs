using InverseToSRP;

string userName = "Ayşe Fatma";

Transactions transactions = new Transactions();

transactions.SendNewPassword(userName);

transactions.GetBalance();

transactions.GetProfileInformation(userName);