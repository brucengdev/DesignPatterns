namespace Builder;

public enum Side
{
    North,
    South,
    West,
    East
}
public class Room
{
    private object[] _things = new object[4];
    public void SetSide(Side side, object thingy)
    {
        _things[(int)side] = thingy;
    }
}