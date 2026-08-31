namespace StrategyPattern;

public class StrategyTests
{
    [Fact]
    public void TestSpendingReports()
    {
        //the test is the client.
        var context = new SpendingReportData();
        context.AddSpending(100, new DateTime(2025, 01, 02));
        context.AddSpending(120, new DateTime(2025, 01, 03));
        context.AddSpending(10, new DateTime(2025, 02, 05));
        context.AddSpending(40, new DateTime(2025, 03, 04));

        var outputStream = new MemoryStream();
        context.BuildReport(new MonthlyReportBuilder(), outputStream);

        outputStream.Position = 0;
        var output = ReadReport(outputStream);
        var expectedReport = ("2025-1:220\n"
                              + "2025-2:10\n"
                              + "2025-3:40\n")
                            .ReplaceLineEndings();
        Assert.Equal(expectedReport, output);

        outputStream.Position = 0;
        outputStream.SetLength(0);
        context.BuildReport(new YearlyReportBuilder(), outputStream);
        outputStream.Position = 0;
        output = ReadReport(outputStream);
        expectedReport = "2025:270\n".ReplaceLineEndings();
        Assert.Equal(expectedReport, output);
    }

    private static string ReadReport(MemoryStream outputStream)
    {
        var textReader = new StreamReader(outputStream);
        var output = textReader.ReadToEnd().ReplaceLineEndings();
        return output;
    }
}
