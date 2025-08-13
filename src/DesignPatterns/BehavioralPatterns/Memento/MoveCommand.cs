namespace Memento;

public class MoveCommand: AbstractCommand
{
    public MoveCommand(Table table, int x, int y) : base(table)
    {
    }

    public override void Execute()
    {
    }
}