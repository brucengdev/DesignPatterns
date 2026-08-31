namespace FactoryMethod;

public class MazeGame
{
    public Maze CreateMaze()
    {
        var maze = MakeMaze();

        Room r1 = MakeRoom(1);
        Room r2 = MakeRoom(2);
        Door door = MakeDoor(r1, r2);

        maze.AddRoom(r1);
        maze.AddRoom(r2);

        r1.SetSide(Side.North, MakeWall());
        r1.SetSide(Side.South, MakeWall());
        r1.SetSide(Side.West, MakeWall());
        r1.SetSide(Side.East, door);
        
        r2.SetSide(Side.North, MakeWall());
        r2.SetSide(Side.South, MakeWall());
        r2.SetSide(Side.West, door);
        r2.SetSide(Side.East, MakeWall());
        
        return maze;
    }

    public virtual Maze MakeMaze()
    {
        return new Maze();
    }

    //factory methods
    public virtual Room MakeRoom(int roomNumber)
    {
        return new Room(roomNumber);
    }

    public virtual Wall MakeWall()
    {
        return new Wall();
    }

    public virtual Door MakeDoor(Room r1, Room r2)
    {
        return new Door(r1, r2);
    }
}