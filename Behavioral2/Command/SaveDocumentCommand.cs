namespace Command;

public class SaveDocumentCommand: ICommand
{
    public Application _application;

    public SaveDocumentCommand(Application application)
    {
        _application = application;
    }
    public void Execute()
    {
        _application.Document.Save();
    }
}