namespace Command;

public class CloseDocumentCommand: ICommand
{
    private Application _application;
    public CloseDocumentCommand(Application application)
    {
        _application = application;
    }
    public void Execute()
    {
        _application.Document = null;
    }
}