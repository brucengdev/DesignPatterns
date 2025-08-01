namespace IteratorPattern;

public interface Iterable2<TItem>
{
    Iterator2<TItem> CreateIterator();
}