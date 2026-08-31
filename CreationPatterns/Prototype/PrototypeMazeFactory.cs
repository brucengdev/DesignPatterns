namespace Prototype;

public class PrototypeMazeFactory: MazeFactory
{
    private Maze _prototypeMaze;
    private Room _prototypeRoom;
    private Wall _prototypeWall;
    private Door _prototypeDoor;
    public PrototypeMazeFactory(Maze maze, Wall wall, Room room, Door door)
    {
        _prototypeMaze = maze;
        _prototypeRoom = room;
        _prototypeWall = wall;
        _prototypeDoor = door;
    }

    public override Door CreateDoor(Room r1, Room r2)
    {
        var door = _prototypeDoor.Clone() as Door;
        door.Initialize(r1, r2);
        return door;
    }

    public override Wall CreateWall()
    {
        var result = _prototypeWall.Clone();
        return (result as Wall)!;
    }

    public override Room CreateRoom(int roomNumber)
    {
        var result = _prototypeRoom.Clone() as Room;
        result.Initialize(roomNumber);
        return result;
    }

    public override Maze CreateMaze()
    {
        var result = _prototypeMaze.Clone() as Maze;
        return result;
    }
}