namespace AbstractFactory;

public class MazeFactory
{
    public virtual Maze CreateMaze()
    {
        return new Maze();
    }
    public virtual Wall CreateWall()
    {
        return new Wall();
    }

    public virtual Door CreateDoor(Room r1, Room r2)
    {
        return new Door(r1, r2);
    }

    public virtual Room CreateRoom(int id)
    {
        return new Room(id);
    }
}