namespace Command;

public interface Command
{
    void Execute();
    void Unexecute();
}