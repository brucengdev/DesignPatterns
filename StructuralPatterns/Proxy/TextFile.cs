namespace Proxy;

//The actual object that is resource intensive
public class TextFile: ITextFile
{
    private string _fileName;
    public TextFile(string fileName)
    {
        _fileName = fileName;
    }

    public string Name => _fileName;

    public string Content => File.ReadAllText(_fileName);
}