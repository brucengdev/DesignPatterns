namespace Builder;

public class Tests
{
    [Fact]
    public void Test1()
    {
        var builder = new StandardMazeBuilder();
        var game = new MazeGame();
        var maze = game.CreateMaze(builder);
    }
}