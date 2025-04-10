namespace Adapter;

public class Client
{
    public void Process(IShape shape)
    {
        var manipulator = shape.CreateManipulator();
        Point bottomLeft = new(), topRight = new();
        shape.BoundingBox(ref bottomLeft, ref topRight);
    }
}