using Xunit.Abstractions;
namespace Decorator;
public class UnitTest1
{
    private readonly ITestOutputHelper output;

    public UnitTest1(ITestOutputHelper output)
    {
        this.output = output;
    }
    
    [Fact]
    public void Test1()
    {
        //arrange
        var text = new IndentDecorator(
            new QuotedDecorator(
                new TextComponent("Actions speak louder than words."))
        );
        
        //act
        var result = text.Draw();
        
        //assert
        Assert.Equal("  \"Actions speak louder than words.\"", result);
        output.WriteLine(result);
    }
}