namespace Composite;

public class CompositeEquipment: Equipment
{
    public CompositeEquipment(string name) : base(name)
    {
    }

    public override int Prize()
    {
        int prize = 0;
        var iterator = GetIterator();
        foreach (var child in iterator)
        {
            prize += child.Prize();
        }

        return prize;
    }

    private HashSet<Equipment> _children = new();
    public override IEnumerable<Equipment> GetIterator()
    {
        return _children;
    }

    public override void Add(Equipment child)
    {
        _children.Add(child);
    }

    public override void Remove(Equipment child)
    {
        _children.Remove(child);
    }
}