namespace IteratorPattern;

public class ArrayIterator<TItem>: Iterator2<TItem>
{
    private TItem[] _items;
    private int _current = 0;
    public ArrayIterator(TItem[] items)
    {
        _items = items;
    }

    public TItem GetCurrentItem()
    {
        return _items[_current];
    }

    public void Next()
    {
        _current++;
    }

    public bool IsDone => _current >= _items.Length;
}