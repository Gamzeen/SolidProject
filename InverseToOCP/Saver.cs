namespace InverseToOCP;

public class Saver
{
    public void SaveToFile(string content, string fileType)
    {
        if (fileType == "sql")
        {
            Console.WriteLine("Veri SQL veritabanına kaydedildi: " + content);
        }
        else if (fileType == "csv")
        {
            Console.WriteLine("Veri CSV dosyasına kaydedildi: " + content);
        }
        else if (fileType == "pdf")
        {
            Console.WriteLine("Veri PDF dosyasına kaydedildi: " + content);
        }
        else
        {
            Console.WriteLine("Desteklenmeyen dosya türü.");
        }
    }
}