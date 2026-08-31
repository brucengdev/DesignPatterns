namespace Proxy;

public class FileContentLoader
{
    private List<string> _readFiles = new();
    public IReadOnlyCollection<string> ReadFiles => _readFiles.AsReadOnly();

    public IEnumerable<string> ReadLines(string fileName)
    {
        _readFiles.Add(fileName);
        return File.ReadLines(fileName);
    }

    public void Clear()
    {
        _readFiles.Clear();
    }
}