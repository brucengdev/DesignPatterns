namespace AbstractFactory;

public class InMemRepoFactory : IRepoFactory
{
    public IAccountRepository CreateAccountRepository()
    {
        return new InMemAccountRepository();
    }

    public IUserRepository CreateUserRepository()
    {
        return new InMemUserRepository();
    }
}