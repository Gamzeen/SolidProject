namespace OpenClosedPrinciple;

public class SqlTransactions :ITransactions
{
    public void Save(string content)
    {
        Console.WriteLine("Date saved to SQL: "+ content);
    }
}