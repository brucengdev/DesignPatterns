namespace Command;

public class CreateDocCommand: ICommand
{
    private Application _application;
    public CreateDocCommand(Application application)
    {
        _application = application;
    }

    public void Execute()
    {
        _application.Document = new();
    }
}