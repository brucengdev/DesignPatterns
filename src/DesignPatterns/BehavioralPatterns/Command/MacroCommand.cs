namespace Command;


public class MacroCommand : Command
{
    private List<Command> _commands;
    public MacroCommand(params Command[] commands)
    {
        _commands = commands.ToList();
    }

    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }

    public void Unexecute()
    {
        var reversedCommands = _commands.AsEnumerable()
            .Reverse()
            .ToList();
        foreach (var command in reversedCommands)
        {
            command.Unexecute();
        }
    }
}
