namespace IteratorPattern;

public class Iterable<TItem>
{
    protected TItem _val;
    public Iterable(TItem val)
    {
        _val = val;
    }

    public virtual Iterator<Iterable<TItem>, TItem> CreateIterator()
        => new NullIterator<TItem>(this);

    public TItem GetValue()
    {
        return _val;
    }
}