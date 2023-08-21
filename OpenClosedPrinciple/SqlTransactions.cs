namespace OpenClosedPrinciple;

public class SqlTransactions :ITransactions
{
    public void Save(string content)
    {
        Console.WriteLine("Veri Sql'e kaydedildi: " + content);
    }
}