using OpenClosedPrinciple;

var fileSavers = new List<ITransactions> { new SqlTransactions(), new CsvTransactions() };
var fileManager = new Saver(fileSavers);

string content = "Bu bir test verisidir.";

fileManager.SaveToFile(content);