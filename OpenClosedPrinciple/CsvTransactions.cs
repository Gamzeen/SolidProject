namespace OpenClosedPrinciple;

public class CsvTransactions : ITransactions
{
    public void Save(string content)
    {
        Console.WriteLine("Veri Csv dosyasına kaydedildi: " + content);
    }
}