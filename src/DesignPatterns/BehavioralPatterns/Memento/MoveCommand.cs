namespace Memento;

public class MoveCommand: AbstractCommand
{
    private int _deltaX, _deltaY;
    private ArrowMemento _state;
    public MoveCommand(Furniture target, int x, int y) : base(target)
    {
        _deltaX = x;
        _deltaY = y;
    }

    public override void Execute()
    {
        Target.X += _deltaX;
        Target.Y += _deltaY;
        var resolver = new ArrowMemento.ArrowResolver(Target);
        _state = resolver.CreateMemento();
        resolver.ResolveArrow(_deltaX, _deltaY);
    }

    public override void Unexecute()
    {
        Target.X -= _deltaX;
        Target.Y -= _deltaY;
        var resolver = new ArrowMemento.ArrowResolver(Target);
        resolver.SetState(_state);
    }
}