namespace Command;

public class Application
{
    public Menu Menu { get; }

    public Document Document { get; set; }
    public Application()
    {
        Menu = new Menu();
        Menu.Add(new MenuItem("CreateDoc", new CreateDocCommand(this)));
        Menu.Add(new MenuItem("SaveDoc", new SaveDocumentCommand(this)));
        Menu.Add(new MenuItem("CloseDoc", new CloseDocumentCommand(this)));
    }
}