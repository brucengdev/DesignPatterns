namespace FactoryMethod;

public class Tests
{
    [Fact]
    public void Test1()
    {
        var game = new MazeGame();
        var maze = game.CreateMaze();
    }
}