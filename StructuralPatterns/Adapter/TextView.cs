namespace Adapter;

public class TextView
{
    public (int, int) GetOrigin()
    {
        return (1, 2);
    }

    public (int, int) GetExtent()
    {
        return (100, 10);
    }

    public bool IsEmpty()
    {
        return false;
    }
}