namespace IteratorPattern;

public interface Iterator<T>
{
    void First();
    void Next();
    bool IsDone();
    T GetCurrentItem();
}