namespace Command;

public class Tests
{
    [Fact]
    public void TestCommands()
    {
        var app = new Application();
        var commands = new List<Command>
        {
            new OpenCommand(app),
            new SaveCommand(new Document("c:/temp/myfile.txt")),
            new MacroCommand(new OpenCommand(app), new SaveCommand(new Document("c:/temp/myfile2.txt")))
        };

        foreach (var command in commands)
        {
            command.Execute();
        }

        commands.Reverse();

        foreach (var command in commands)
        {
            command.Unexecute();
        }
    }
}
