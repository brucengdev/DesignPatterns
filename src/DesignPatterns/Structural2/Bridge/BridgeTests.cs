using Bridge.Implementation;
using Bridge.Models;

namespace Bridge;

public class BridgeTests
{
    [Fact]
    public async Task ExpenseIncomeReportExporter_TestDifferentExportFormats()
    {
        //arrange
        var report = new FinancialReport()
        {
            Expenses = [
                new Expense { Amount = -20, Category = "food" },
                new Expense { Amount = -1000, Category = "rent" }
            ],
            Income = [
                new Income { Amount = 500, Category = IncomeCategory.Salary },
                new Income { Amount = 100, Category = IncomeCategory.Divident }
            ]
        };

        var markDownFormat = new MarkDownFormat();
        var htmlFormat = new HTMLFormat();
        var reportExporter = new ExpenseIncomeReportExporter(markDownFormat);

        //act
        //For simplicity, the report is exported as string
        var markDownReport = reportExporter.Export(report);

        //changing implementation at runtime
        reportExporter.SetFormat(htmlFormat);

        //act and assert
        var htmlReport = reportExporter.Export(report);
        await Verify(new { markDownReport, htmlReport});
    }

    [Fact]
    public async Task ExpenseReportExporter_TestDifferentExportFormats()
    {
        //arrange
        var report = new FinancialReport()
        {
            Expenses = [
                new Expense { Amount = -20, Category = "food" },
                new Expense { Amount = -1000, Category = "rent" }
            ],
            Income = [
                new Income { Amount = 500, Category = IncomeCategory.Salary },
                new Income { Amount = 100, Category = IncomeCategory.Divident }
            ]
        };

        var markDownFormat = new MarkDownFormat();
        var htmlFormat = new HTMLFormat();
        var reportExporter = new ExpenseReportExporter(markDownFormat);

        //act
        //For simplicity, the report is exported as string
        var markDownReport = reportExporter.Export(report);

        //changing implementation at runtime
        reportExporter.SetFormat(htmlFormat);

        //act and assert
        var htmlReport = reportExporter.Export(report);
        await Verify(new { markDownReport, htmlReport});
    }
}
