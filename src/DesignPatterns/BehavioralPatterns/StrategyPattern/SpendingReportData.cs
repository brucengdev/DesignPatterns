namespace StrategyPattern;

public class Spending
{
    public float Amount { get; set; }
    public DateTime DateTime { get; set; }
}

public class SpendingReportData
{
    private List<Spending> _records = new();
    public void AddSpending(float amount, DateTime dateTime)
    {
        _records.Add(new Spending()
        {
            Amount = amount,
            DateTime = dateTime
        });
    }

    public void BuildReport(IReportBuilder reportBuilder, Stream outputStream)
    {
        reportBuilder.Build(_records, outputStream);
    }
}