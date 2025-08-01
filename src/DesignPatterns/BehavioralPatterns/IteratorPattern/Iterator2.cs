namespace IteratorPattern;

public interface Iterator2<TItem>
{
    TItem GetCurrentItem();
    void Next();
    bool IsDone { get; }
}