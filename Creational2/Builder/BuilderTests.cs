using Builder.Builders;
using Builder.Models;

namespace Builder;

/// <summary>
/// The tests act as client, while the director is the report maker.
/// The director is reused, while the builders can be replaced.
/// </summary>
public class BuilderTests
{
    [Fact]
    public async Task TestBuildExpenseHTMLReport()
    {
        //arrange
        var data = CreateTestReportData();
        var builder = new ExpenseHTMLBuilder();
        var reportMaker = new ReportMaker(builder);

        //act
        reportMaker.MakeReport(data);

        //assert
        var results = builder.GetHTMLResult();
        await Verify(results);
    }

    [Fact]
    public async Task TestBuildInvestmentHTMLReport()
    {
        //arrange
        var data = CreateTestReportData();
        var builder = new InvestmentHTMLBuilder();
        var reportMaker = new ReportMaker(builder);

        //act
        reportMaker.MakeReport(data);

        //assert
        var results = builder.GetHTMLResult();
        await Verify(results);
    }

    [Fact]
    public async Task TestBuildExpensesAndInvestmentsMarkdownReport()
    {
        //arrange
        var data = CreateTestReportData();
        var builder = new ExpenseInvestmentMarkdownBuilder();
        var reportMaker = new ReportMaker(builder);

        //act
        reportMaker.MakeReport(data);

        //assert
        var results = builder.GetMarkDownResult();
        await Verify(results);
    }

    private Report CreateTestReportData()
    {
        return new()
        {
            Entries = [
                new Expense() { Amount = -20, Description = "Supermarket" },
                new Investment() { Amount = -1000, Category= InvestmentCategory.Stocks },
                new Expense() { Amount = -30, Description = "Books" },
                new Expense() { Amount = -120, Description = "Rent" },
                new Investment() { Amount = -100, Category= InvestmentCategory.Gold },
                new Investment() { Amount = -2000, Category= InvestmentCategory.RealEstate }
            ]
        };
    }
}
