namespace Adapter;

public class TextShape: TextView, IShape
{
    public void BoundingBox(ref Point bottomLeft,ref Point topRight)
    {
        var (originX, originY) = GetOrigin();
        var (width, height) = GetExtent();

        bottomLeft = new Point(originX, originY);
        topRight = new Point(originX + width, originY + height);
    }

    public IManipulator CreateManipulator()
    {
        return new TextManipulator(this);
    }
}