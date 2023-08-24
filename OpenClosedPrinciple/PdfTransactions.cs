namespace OpenClosedPrinciple;

public class PdfTransactions : ITransactions
{
    public void Save(string content)
    {
        Console.WriteLine("Date saved to PDF file : " + content);
    }
}