namespace AbstractFactory;

public interface IRepoFactory
{
    IAccountRepository CreateAccountRepository();
    IUserRepository CreateUserRepository();
}