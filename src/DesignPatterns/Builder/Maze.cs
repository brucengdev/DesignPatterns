namespace Builder;

public class Maze
{
    private List<Room> _rooms = new();
    public void AddRoom(Room room)
    {
        _rooms.Add(room);
    }
}