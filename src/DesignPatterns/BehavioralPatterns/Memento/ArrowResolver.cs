namespace Memento;

public class ArrowResolver
{
    private Furniture _target;
    public ArrowResolver(Furniture target)
    {
        _target = target;
    }

    public void ResolveArrow(int deltaX, int deltaY)
    {
        _target.Arrow.X = -deltaX;//arrow points to the opposite direction of the movement
        _target.Arrow.Y = -deltaY;
    }
}