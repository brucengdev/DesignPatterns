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
        
        Assert.Equal(0, table.Arrow.X);
        Assert.Equal(0, table.Arrow.Y);
    }
    
    [Fact]
    public void TestMoveCommand()
    {
        //arrange
        var table = new Table();
        var command = new MoveCommand(table, 10, 20);
        
        //act
        command.Execute();
        
        //assert
        Assert.Equal(10, table.X);
        Assert.Equal(20, table.Y);
    }
    
    [Fact]
    public void TestMoveCommandTwice()
    {
        //arrange
        var table = new Table();
        var command1 = new MoveCommand(table, 10, 20);
        var command2 = new MoveCommand(table, 2, -5);
        
        //act
        command1.Execute();
        command2.Execute();
        
        //assert
        Assert.Equal(12, table.X);
        Assert.Equal(15, table.Y);
    }
    
    [Fact]
    public void TestMoveCommandTwiceAndUnexecute()
    {
        //arrange
        var table = new Table();
        var command1 = new MoveCommand(table, 10, 20);
        var command2 = new MoveCommand(table, 2, -5);
        
        //act
        command1.Execute();
        command2.Execute();
        command2.Unexecute();
        
        //assert
        Assert.Equal(10, table.X);
        Assert.Equal(20, table.Y);
    }
}