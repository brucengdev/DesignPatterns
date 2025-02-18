namespace AbstractFactory;

public class MazeFactoryTests
{
    [Fact]
    public void CreateMaze()
    {
        var mazeFactory = new MazeFactory();
        var maze = mazeFactory.CreateMaze();
        var r1 = mazeFactory.CreateRoom(1);
        var r2 = mazeFactory.CreateRoom(2);
        var door = mazeFactory.CreateDoor(r1, r2);
        maze.AddRoom(r1);
        maze.AddRoom(r2);
        r1.SetSide(Side.North, mazeFactory.CreateWall());
        r1.SetSide(Side.South, mazeFactory.CreateWall());
        r1.SetSide(Side.West, mazeFactory.CreateWall());
        r1.SetSide(Side.East, door);
        
        r2.SetSide(Side.North, mazeFactory.CreateWall());
        r2.SetSide(Side.South, mazeFactory.CreateWall());
        r2.SetSide(Side.West, door);
        r2.SetSide(Side.East, mazeFactory.CreateWall());
    }
}