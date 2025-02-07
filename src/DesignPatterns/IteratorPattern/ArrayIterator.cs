namespace IteratorPattern;

public class ArrayIterator<T>: Iterator<T>
{
    private T[] _array;
    private int _currentIndex;
    public ArrayIterator(T[] array)
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

    public T GetCurrentItem()
    {
        if (_array.Length == 0)
        {
            return default; 
        }

        return _array[_currentIndex];
    }
}