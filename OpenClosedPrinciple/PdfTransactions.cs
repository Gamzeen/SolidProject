namespace OpenClosedPrinciple;

public class PdfTransactions : ITransactions
{
    public void Save(string content)
    {
        Console.WriteLine("Veri Pdf dosyasına kaydedildi: " + content);
    }
}