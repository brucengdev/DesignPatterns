namespace Command;

public class OpenCommand: Command
{
    private Application _app;
    private Document _doc;
    public OpenCommand(Application app)
    {
        _app = app;
    }

    public void Execute()
    {
        var fileName = AskUserForFileName();
        _doc = new Document(fileName);
        _app.Add(_doc);
        _doc.Open();
    }

    public void Unexecute()
    {
        _doc.Close();
        _app.Remove(_doc);
        _doc = null;
    }

    private string AskUserForFileName()
    {
        //open a file dialog and return the selected file name
        return "c:/temp/myfile.txt";
    }
}