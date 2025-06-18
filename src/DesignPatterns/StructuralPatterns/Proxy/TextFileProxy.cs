namespace Proxy;

public class TextFileProxy: ITextFile
{
    private string _fileName;
    private TextFile _textFile = null;
    public TextFileProxy(string fileName)
    {
        _fileName = fileName;
    }

    public string Name => _fileName;

    public string Content
    {
        get
        {
            if (_textFile == null)
            {
                _textFile = new TextFile(_fileName);
            }

            return _textFile.Content;
        }
    }
}