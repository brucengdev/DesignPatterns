namespace Memento;

public abstract class AbstractCommand
{
    public AbstractCommand(Furniture target)
    {
    }

    public abstract void Execute();
}