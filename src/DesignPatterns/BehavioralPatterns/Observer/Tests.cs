using Shouldly;

namespace Observer;

public class Tests
{
    [Fact]
    public void TestObserver()
    {
        //arrange
        var nameTextBox = new TextBox();
        var welcomeMessage = new Message("Welcome, {name}!", nameTextBox);
        var goodbyeMessage = new Message("Goodbye, {name}!", nameTextBox);
        nameTextBox.Attach(welcomeMessage);
        nameTextBox.Attach(goodbyeMessage);
        
        //act
        nameTextBox.SetText("John");
        
        //assert
        welcomeMessage.MessageText.ShouldBe("Welcome, John!");
        goodbyeMessage.MessageText.ShouldBe("Goodbye, John!");
        
        //act
        nameTextBox.SetText("Mary");
        
        //assert
        welcomeMessage.MessageText.ShouldBe("Welcome, Mary!");
        goodbyeMessage.MessageText.ShouldBe("Goodbye, Mary!");
    }
}