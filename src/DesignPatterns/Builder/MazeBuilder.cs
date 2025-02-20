namespace Builder;

public abstract class MazeBuilder
{
    public virtual void BuildMaze()
    {
    }

    public virtual void BuildRoom(int roomNumber)
    {
    }

    public virtual Maze GetMaze()
    {
        return null;
    }
}