namespace IteratorPattern;

public class PreorderIterator<T, TItem>: Iterator<T, TItem>
where T: Iterable<TItem>
{
    private Iterable<T> _root;
    private Iterable<T> _current;
    public PreorderIterator(Iterable<T> root)
    {
        _root = root;
        First();
    }
    
    public void First()
    {
        _current = _root;
    }

    public void Next()
    {
        
    }

    public bool IsDone()
    {
        throw new NotImplementedException();
    }

    public T GetCurrentItem()
    {
        throw new NotImplementedException();
    }
}