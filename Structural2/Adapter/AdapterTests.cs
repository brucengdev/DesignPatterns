using Adapter.ContactManager;
using Adapter.ExpenseManager;
using Shouldly;
namespace Adapter;

/// <summary>
/// This example introduces two systems.
/// One is a contact management system for managing contacts.
/// One is a expense management system for managing expenses.
/// Two systems are developed independently.
/// To use the same profile in both, we need to create an adapter.
/// </summary>
public class AdapterTests
{
    [Fact]
    public void ClassAdapter()
    {
        var contactManager = new ContactManager.ContactManager();
        var expenseManager = new ExpenseManager.ExpenseManager();

        var john = new ContactUserAdapter()
        {
            PhoneNumber = "12345678",
            ID = "1234",
            Name = "John",
            Occupation = "Carpenter"
        };

        //assert that same object can be used for both systems
        //this seems to demonstrate the two way adapter
        john.ContactNumber.ShouldBe("12345678");

        contactManager.Add(john);
        contactManager.SearchByName("oh").ShouldContain(john);

        expenseManager.Add(john);
        expenseManager.Users.ShouldContain(john);

        expenseManager.LogExpense(john, -12);
        john.GetExpenses().ShouldContain(ex => ex.Amount == -12);
    }

    [Fact]
    public void ObjectAdapter()
    {
        var contactManager = new ContactManager.ContactManager();
        var expenseManager = new ExpenseManager.ExpenseManager();

        var john = new User()
        {
            ID = "1234",
            Occupation = "Carpenter",
            ContactNumber = "12345678"
        };

        var wrappedContact = new ContactFromUser(john)
        {
            Name = "John"
        };

        //assert that same object can be used for both systems
        //this seems to demonstrate the two way adapter
        john.ContactNumber.ShouldBe("12345678");

        wrappedContact.PhoneNumber = "66668888";
        wrappedContact.PhoneNumber.ShouldBe("66668888");
        john.ContactNumber.ShouldBe("66668888");//PhoneNumber is mapped to ContactNumber

        contactManager.Add(wrappedContact);
        contactManager.SearchByName("oh").ShouldContain(wrappedContact);

        expenseManager.Add(john);
        expenseManager.Users.ShouldContain(john);

        expenseManager.LogExpense(john, -12);
        john.GetExpenses().ShouldContain(ex => ex.Amount == -12);
    }
}
