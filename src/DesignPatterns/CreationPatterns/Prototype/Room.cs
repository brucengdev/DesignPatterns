namespace Prototype;

public enum Side
{
    North,
    South,
    West,
    East
}
public class Room: ICloneable
{
    private int _roomNumber;
    public Room(int number)
    {
        Initialize(number);
    }
    private object[] _things = new object[4];
    public void SetSide(Side side, object thingy)
    {
        _things[(int)side] = thingy;
    }

    public void Initialize(int roomNumber)
    {
        _roomNumber = roomNumber;
    }

    public object Clone()
    {
        return new Room(_roomNumber);
    }
}