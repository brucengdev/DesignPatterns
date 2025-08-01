namespace IteratorPattern;

public class NullIterator<TItem>: Iterator<Iterable<TItem>, TItem>
{
    private Iterable<TItem> _singleItem;
    public NullIterator(Iterable<TItem> singleItem)
    {
        _singleItem = singleItem;
    }
    public void First()
    {
        
    }

    public void Next()
    {
        
    }

    public bool IsDone()
    {
        return true;
    }

    public Iterable<TItem> GetCurrentItem()
    {
        return _singleItem;
    }
}