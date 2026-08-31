using Adapter.ContactManager;
using Adapter.ExpenseManager;

namespace Adapter;

public class ContactFromUser : IContact
{
    private User _user;
    public ContactFromUser(User user)
    {
        _user = user;
    }
    public string Name { get; set; } = "";
    public string PhoneNumber { 
        get
        {
            return _user.ContactNumber;
        }
        set
        {
            _user.ContactNumber = value;
        }
    }
}