namespace AbstractFactory;

public class Room
{
    private int _id;
    public Room(int id)
    {
        _id = id;
    }
    
    private Dictionary<Side, object> arounds = new ();

    public void SetSide(Side side, object thingy)
    {
        arounds[side] = thingy;
    }
}