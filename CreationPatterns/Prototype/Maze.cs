namespace Prototype;

public class Maze: ICloneable
{
    private List<Room> _rooms = new();
    public void AddRoom(Room room)
    {
        _rooms.Add(room);
    }

    public object Clone()
    {
        return new Maze();
    }
}