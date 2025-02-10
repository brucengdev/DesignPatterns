namespace IteratorPattern;

public class Iterator<TItem>: Iterator<Iterable<TItem>, TItem>
{
    private Iterable<TItem>[] _array;
    private int _currentIndex;
    public Iterator(Iterable<TItem>[] array)
    {
        _array = array;
    }
    public void First()
    {
        _currentIndex = 0;
    }

    public void Next()
    {
        if (_currentIndex < _array.Length - 1)
        {
            _currentIndex++;
        }
    }

    public bool IsDone()
    {
        return _currentIndex >= _array.Length - 1;
    }

    public Iterable<TItem> GetCurrentItem()
    {
        if (_array.Length == 0)
        {
            return default; 
        }

        return _array[_currentIndex];
    }
}