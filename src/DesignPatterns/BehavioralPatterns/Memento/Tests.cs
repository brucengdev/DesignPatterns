namespace Memento;

public class Tests
{
    [Fact]
    public void TestInitialTableState()
    {
        //arrange
        var table = new Table();
        
        //assert
        Assert.Equal(0, table.X);
        Assert.Equal(0, table.Y);
    }
    
    [Fact]
    public void TestMoveCommand()
    {
        //arrange
        var table = new Table();
        var command = new MoveCommand(table, 10, 20);
        
        //act
        command.Execute();
    }
}