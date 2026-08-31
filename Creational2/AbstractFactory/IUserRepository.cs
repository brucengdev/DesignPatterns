using AbstractFactory;

public interface IUserRepository
{
    void Create(string name, int age);
    IList<User> GetUsers();
}