using LiskovSubstitutionPrinciple;

var aBank = new ABank();
var bBank = new BBank();
var cBank = new CBank();

aBank.TekCekim();
aBank.KrediKartiTaksitli();
aBank.Pay3D();

bBank.TekCekim();
bBank.KrediKartiTaksitli();
bBank.Pay3D();

cBank.TekCekim();
cBank.KrediKartiTaksitli();