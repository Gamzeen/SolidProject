namespace OpenClosedPrinciple;

public class Saver
{
    private readonly List<ITransactions> _transactions;

    public Saver(List<ITransactions> transactions)
    {
        _transactions = transactions;
    }

    public void SaveToFile(string content)
    {
        foreach (var fileSaver in _transactions)
        {
            fileSaver.Save(content);
        }
    }
}