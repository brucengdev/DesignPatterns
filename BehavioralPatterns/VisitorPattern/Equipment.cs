using System.Collections.ObjectModel;

namespace VisitorPattern;

public abstract class Equipment
{
    private string _name;
    public string Name => _name;
    
    public Equipment(string name)
    {
        _name = name;
    }

    public abstract int Prize();

    public virtual IEnumerable<Equipment> GetIterator()
    {
        return new ReadOnlyCollection<Equipment>(new List<Equipment>());
    }

    public virtual void Add(Equipment child)
    {
        throw new NotSupportedException("Adding to non-composite equipment is not supported");
    }

    public virtual void Remove(Equipment child)
    {
        throw new NotSupportedException("Removing children from non-composite equipment is not supported");
    }

    public virtual void Accept(Visitor visitor)
    {
    }
}