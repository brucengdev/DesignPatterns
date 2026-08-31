using System.Text;

namespace FactoryMethod;


class TestApplication: SpendingsReportMaker
{
    protected override IWriter CreateWriter()
    {
        return new TestWriter();
    }
}

class TestWriter: IWriter
{
    private static StringBuilder _written = new();
    public static string Written => _written.ToString();

    public void Write(string data)
    {
        _written.Append(data);
    }
}

public class SpendingsReportMakerTests
{
    [Fact]
    public async Task TestWriteReport()
    {
        var app = new TestApplication();

        List<Spending> spendings = [
            new Spending { Category = "Shopping", Amount = -10 },
            new Spending { Category = "Shopping", Amount = -5 },
            new Spending { Category = "Gifts", Amount = -20 },
            new Spending { Category = "Gifts", Amount = -14 },
            new Spending { Category = "Shopping", Amount = -12 }
        ];
        app.WriteReport(spendings);

        await Verify(TestWriter.Written);
    }
}
