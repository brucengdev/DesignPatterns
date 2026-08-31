namespace AbstractFactory.FileSystemRepo;

public class FileSystemRepoFactory : IRepoFactory
{
    public IAccountRepository CreateAccountRepository()
    {
        return new FileSystemAccountRepository();
    }

    public IUserRepository CreateUserRepository()
    {
        return new FileSystemUserRepository();
    }
}