namespace IteratorPattern;

/// <summary>
/// The iterator pattern helps encapsulate traversal over items
/// in various different data structures.
/// Clients does not need to care how items are organized.
/// The algorithm can be replaced easily.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface Iterator<T, TItem> where T: Iterable<TItem>
{
    void First();
    void Next();
    bool IsDone();
    T GetCurrentItem();
}