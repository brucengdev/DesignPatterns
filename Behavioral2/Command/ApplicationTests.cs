namespace Command;
using Shouldly;

public class ApplicationTests
{
    public ApplicationTests()
    {
        //clean up before running tests.
        File.Delete("document.txt");
    }
    
    [Fact]
    public void TestWordProcessor()
    {
        //arrange
        var application = new Application();

        //act an assert
        File.Exists("document.txt").ShouldBeFalse();
        application.Document.ShouldBeNull();
        
        //simulate clicking
        application.Menu.Item["CreateDoc"].Click();

        application.Document.ShouldNotBeNull();

        application.Document.Text.ShouldBe("");
        application.Document.AppendText("The doc has been modified");

        application.Menu.Item["SaveDoc"].Click();
        
        File.Exists("document.txt").ShouldBeTrue();

        application.Menu.Item["CloseDoc"].Click();
        application.Document.ShouldBeNull();
    }
}