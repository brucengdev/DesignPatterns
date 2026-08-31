namespace ChainOfResponsibility;

public class UnitTest1
{
    [Fact]
    public void TestChainOfResponsibility()
    {
        var app = new Application(HelpTopic.Application);
        var dialog = new Dialog(app, HelpTopic.Printing);
        var button = new Button("Print", dialog, HelpTopic.NoTopic);
        
        Assert.Equal("This is a dialog for printing.", button.HandleHelp());
        
        Assert.Equal("This is a dialog for printing.", dialog.HandleHelp());
        
        Assert.Equal("No help message", app.HandleHelp());
    }
}