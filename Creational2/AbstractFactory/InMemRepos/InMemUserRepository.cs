namespace AbstractFactory;

public class InMemUserRepository : IUserRepository
{
    private List<User> Users = new();
    public void Create(string name, int age)
    {
        Users.Add(new(name, age));
    }

    public IList<User> GetUsers()
    {
        return Users.OrderBy(u => u.Name).ToList().AsReadOnly();
    }
}