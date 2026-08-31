namespace Prototype;

public class Door: ICloneable
{
    private Room _r1, _r2;

    public Door(Room r1, Room r2)
    {
        _r1 = r1;
        _r2 = r2;
    }
    
    public void Initialize(Room r1, Room r2) { }
    public object Clone()
    {
        return new Door(_r1, _r2);
    }
}