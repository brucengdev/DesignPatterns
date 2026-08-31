namespace Adapter;

public interface IShape
{   
    void BoundingBox(ref Point bottomLeft, ref Point topRight);
    IManipulator CreateManipulator();
}