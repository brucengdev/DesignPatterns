namespace Adapter;

public class Tests
{
    [Fact]
    public void Test1()
    {
        var client = new Client();
        var textShape = new TextShape();
        client.Process(textShape);
    }
}