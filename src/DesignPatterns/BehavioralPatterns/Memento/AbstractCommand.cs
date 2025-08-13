namespace Memento;

public abstract class AbstractCommand
{
    protected Furniture Target { get; }
    public AbstractCommand(Furniture target)
    {
        Target = target;
    }

    public abstract void Execute();
}