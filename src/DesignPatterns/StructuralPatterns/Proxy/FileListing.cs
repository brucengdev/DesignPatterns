namespace Proxy;

public class FileListing
{
    private List<ITextFile> _textFiles;
    public FileListing(params string[] files)
    {
        _textFiles = files.Select(f => new TextFileProxy(f) as ITextFile).ToList();
    }

    public void ShowListing()
    {
        Console.WriteLine("Files:");
        foreach (var file in _textFiles)
        {
            Console.WriteLine(file.Name);
        }
    }

    public void ShowCombinedContents()
    {
        Console.WriteLine("File contents:");
        foreach (var file in _textFiles)
        {
            Console.WriteLine(file.Content);
        }
    }
}