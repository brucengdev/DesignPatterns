using System.Text;

namespace FactoryMethod;

public class FactoryMethodTests
{
    [Fact]
    public async Task InMemoryReportMaker_must_writes_to_memory()
    {
        //arrange
        var sb = new StringBuilder();
        var sut = new InMemoryReportMaker(sb);

        //act
        sut.WriteReport([
            new Spending { Category = "Shopping", Amount = -10 },
            new Spending { Category = "Shopping", Amount = -5 },
            new Spending { Category = "Gifts", Amount = -20 },
            new Spending { Category = "Gifts", Amount = -14 },
            new Spending { Category = "Shopping", Amount = -12 }
        ]);

        //assert
        await Verify(sb.ToString());
    }

    [Fact]
    public async Task FileSystemReportMaker_must_writes_to_filesystem()
    {
        //arrange
        File.Delete("myreport.txt");
        var sut = new FileSystemReportMaker("myreport.txt");

        //act
        sut.WriteReport([
            new Spending { Category = "Shopping", Amount = -10 },
            new Spending { Category = "Shopping", Amount = -5 },
            new Spending { Category = "Gifts", Amount = -20 },
            new Spending { Category = "Gifts", Amount = -14 },
            new Spending { Category = "Shopping", Amount = -12 }
        ]);

        //assert
        var text = File.ReadAllText("myreport.txt");
        await Verify(text);
    }
}