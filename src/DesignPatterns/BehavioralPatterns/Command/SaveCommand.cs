namespace Command;

public class SaveCommand: Command
{
    private Document _doc;
    public SaveCommand(Document document)
    {
        _doc = document;
    }

    public void Execute()
    {
        _doc.Save();
    }

    public void Unexecute()
    {
        //not sure how to implement this
        //maybe do a backup before saving, and then restore here.
    }
}