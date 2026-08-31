namespace Decorator;

public class DecoratorTest
{
    [Fact]
    public void TestDecorator()
    {
        var message = new PlaintextMessage("God of war");
        var toUpperCase = new UpperCaseMessage(message);
        var withBorder = new Border(toUpperCase);
        var withBorder2 = new Border(withBorder);

        Assert.Equal("<<<<GOD OF WAR>>>>", withBorder2.Message);
        
        //demonstrate changing behavior at runtime
        var toLowerCase = new LowerCaseMessage(message);
        withBorder.Replace(toLowerCase);
        
        Assert.Equal("<<<<god of war>>>>", withBorder2.Message);
    }
}
