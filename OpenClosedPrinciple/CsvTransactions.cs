namespace OpenClosedPrinciple;

public class CsvTransactions : ITransactions
{
    public void Save(string content)
    {
        Console.WriteLine("Date saved to CSV file : " + content);
    }
}