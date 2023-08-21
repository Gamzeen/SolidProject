using InverseToOCP;

Saver fileSaver = new Saver();

string content = "Bu bir test verisidir.";

fileSaver.SaveToFile(content, "sql");
fileSaver.SaveToFile(content, "csv");
fileSaver.SaveToFile(content, "pdf");