using OpenClosedPrinciple;

var fileSavers = new List<ITransactions> { new SqlTransactions(), new CsvTransactions() };
var fileManager = new Saver(fileSavers);

string content = "This is a test data.";

fileManager.SaveToFile(content);