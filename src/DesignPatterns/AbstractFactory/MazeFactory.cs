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

    public virtual Door CreateDoor()
    {
        return new Door();
    }

    public virtual Room CreateRoom(int id)
    {
        return new Room(id);
    }
}