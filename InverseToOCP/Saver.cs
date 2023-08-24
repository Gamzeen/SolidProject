namespace InverseToOCP;

public class Saver
{
    public void SaveToFile(string content, string fileType)
    {
        if (fileType == "sql")
        {
            Console.WriteLine("Date saved to SQL : " + content);
        }
        else if (fileType == "csv")
        {
            Console.WriteLine("Date saved to CSV file : " + content);
        }
        else if (fileType == "pdf")
        {
            Console.WriteLine("Date saved to PDF file : " + content);
        }
        else
        {
            Console.WriteLine("Unsupported file type.");
        }
    }
}