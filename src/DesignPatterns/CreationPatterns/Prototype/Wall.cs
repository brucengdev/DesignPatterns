namespace Prototype;

public class Wall: ICloneable
{
    public object Clone()
    {
        return new Wall();
    }
}