namespace IteratorPattern;

public class MyList
{
    private int[] _items;
    public MyList(params int[] values)
    {
        _items = values;
    }

    public Iterator2<int> CreateIterator()
    {
        return new ArrayIterator<int>(_items);
    }
}