namespace StrategyPattern;

public interface IReportBuilder
{
    void Build(List<Spending> records, Stream outputStream);
}