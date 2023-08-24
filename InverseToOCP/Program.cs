using InverseToOCP;

Saver fileSaver = new Saver();

string content = "This is a test data.";

fileSaver.SaveToFile(content, "sql");
fileSaver.SaveToFile(content, "csv");
fileSaver.SaveToFile(content, "pdf");