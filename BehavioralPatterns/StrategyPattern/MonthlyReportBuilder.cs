namespace StrategyPattern;

public class MonthlyReportBuilder: IReportBuilder
{
    public void Build(List<Spending> records, Stream outputStream)
    {
        var monthlySpendings = records
            .GroupBy(r => new { r.DateTime.Year, r.DateTime.Month })
            .Select(g => new
            {
                Amount = g.Sum(s => s.Amount),
                Year = g.Key.Year,
                Month = g.Key.Month
            });

        var textWriter = new StreamWriter(outputStream);
        foreach(var monthlySpending in monthlySpendings)
        {
            textWriter.WriteLine($"{monthlySpending.Year}-{monthlySpending.Month}:{monthlySpending.Amount}");
        }
        textWriter.Flush();
    }
}