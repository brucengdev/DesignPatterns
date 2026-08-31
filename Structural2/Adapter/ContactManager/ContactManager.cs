namespace Adapter.ContactManager;
public class ContactManager
{
    private List<IContact> _contacts = new();

    public void Add(IContact contact)
    {
        _contacts.Add(contact);
    }

    public IList<IContact> SearchByName(string name)
    {
        return _contacts.Where(c => c.Name.Contains(name)).ToList()
            .AsReadOnly();
    }
}