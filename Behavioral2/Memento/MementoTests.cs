using Shouldly;

namespace Memento;

public class MementoTests
{
    //The tests act as the caretaker in the pattern.
    //This pattern makes more sense in real apps than in a small practice code
    [Fact] public void TestUndoTextField()
    {
        var textField = new TextField();
        textField.SetValue("A chicken");
        var memento = textField.GetMemento();

        textField.Value.ShouldBe("A chicken");
        
        textField.SetValue("A chicken likes to eat grass");
        textField.Value.ShouldBe("A chicken likes to eat grass");

        textField.SetMemento(memento);
        textField.Value.ShouldBe("A chicken");
        
        textField.SetValue("A chicken likes to eat weed");
        textField.Value.ShouldBe("A chicken likes to eat weed");
    }
}