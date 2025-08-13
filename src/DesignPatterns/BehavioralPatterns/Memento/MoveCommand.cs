namespace Memento;

public class MoveCommand: AbstractCommand
{
    private int _deltaX, _deltaY;
    public MoveCommand(Furniture target, int x, int y) : base(target)
    {
        _deltaX = x;
        _deltaY = y;
    }

    public override void Execute()
    {
        Target.X += _deltaX;
        Target.Y += _deltaY;
    }

    public override void Unexecute()
    {
        Target.X -= _deltaX;
        Target.Y -= _deltaY;
    }
}