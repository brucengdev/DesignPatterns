namespace StrategyPattern;

public class YearlyReportBuilder: IReportBuilder
{
    public void Build(List<Spending> records, Stream outputStream)
    {
        var yearlySpendings = records
            .GroupBy(r => new { r.DateTime.Year })
            .Select(g => new
            {
                Amount = g.Sum(s => s.Amount),
                Year = g.Key.Year
            });

        var textWriter = new StreamWriter(outputStream);
        foreach(var yearlySpending in yearlySpendings)
        {
            textWriter.WriteLine($"{yearlySpending.Year}:{yearlySpending.Amount}");
        }
        textWriter.Flush();
    }
}