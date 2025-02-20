namespace Builder;

public class MazeGame
{
    public Maze CreateMaze(MazeBuilder builder)
    {
        builder.BuildMaze();
        builder.BuildRoom(1);
        builder.BuildRoom(2);
        return builder.GetMaze();
    }
}