using InverseToLSP;

var aBank = new ABank();
var bBank = new BBank();
var cBank = new CBank();

aBank.SinglePayment();
aBank.CreditCard();
aBank.Pay3D();

bBank.SinglePayment();
bBank.CreditCard();
bBank.Pay3D();

cBank.SinglePayment();
cBank.CreditCard();
cBank.Pay3D();