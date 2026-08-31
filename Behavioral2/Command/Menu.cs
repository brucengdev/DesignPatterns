namespace Command;

public class Menu
{
    private Dictionary<string, MenuItem> _menuItems = new();
    public IReadOnlyDictionary<string, MenuItem> Item => _menuItems.AsReadOnly();

    public void Add(MenuItem menuItem)
    {
        _menuItems[menuItem.Key] = menuItem;
    }
}