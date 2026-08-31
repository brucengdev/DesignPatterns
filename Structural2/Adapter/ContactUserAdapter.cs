using Adapter.ContactManager;
using Adapter.ExpenseManager;

namespace Adapter;

public class ContactUserAdapter : User, IContact
{
    public string Name { get; set ; } = "";
    public string PhoneNumber { get; set; } = "";

    public override string ContactNumber {
        set
        {
            PhoneNumber = value;
        }
        get
        {
            return PhoneNumber;
        }
    }
}