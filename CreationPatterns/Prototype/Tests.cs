namespace Prototype;

public class Tests
{
    [Fact]
    public void FactoryTests()
    {
        var factory = new PrototypeMazeFactory(
            new Maze(),
            new Wall(),
            new Room(0),
            new Door(null, null)
        );

        var normalMaze = CreateMaze(factory);

        var bombedMazeFactory = new PrototypeMazeFactory(
            new Maze(),
            new BombedWall(),
            new RoomWithABomb(0),
            new Door(null, null)
        );
        var bombedMaze = CreateMaze(bombedMazeFactory);
    }

    private Maze CreateMaze(MazeFactory factory)
    {
        var maze = factory.CreateMaze();

        Room r1 = factory.CreateRoom(1);
        Room r2 = factory.CreateRoom(2);
        Door door = factory.CreateDoor(r1, r2);

        maze.AddRoom(r1);
        maze.AddRoom(r2);

        r1.SetSide(Side.North, factory.CreateWall());
        r1.SetSide(Side.South, factory.CreateWall());
        r1.SetSide(Side.West, factory.CreateWall());
        r1.SetSide(Side.East, door);
        
        r2.SetSide(Side.North, factory.CreateWall());
        r2.SetSide(Side.South, factory.CreateWall());
        r2.SetSide(Side.West, door);
        r2.SetSide(Side.East, factory.CreateWall());
        
        return maze;
    }
}