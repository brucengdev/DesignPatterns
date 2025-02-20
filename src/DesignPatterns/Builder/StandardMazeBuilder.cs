namespace Builder;

public class StandardMazeBuilder: MazeBuilder
{
    private Maze _currentMaze;
    public override void BuildMaze()
    {
        _currentMaze = new();
    }

    public override Maze GetMaze()
    {
        return _currentMaze;
    }

    public override void BuildRoom(int roomNumber)
    {
        var room = new Room();
        _currentMaze.AddRoom(room);
        room.SetSide(Side.North, new Wall());
    }
}