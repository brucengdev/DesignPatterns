using AbstractFactory.FileSystemRepo;
using Shouldly;

namespace AbstractFactory;

public class BankTests
{
    [Fact]
    public void TestWithInMemRepos()
    {
        TestBank(new InMemRepoFactory());
    }

    [Fact]
    public void TestWithFileSystemRepos()
    {
        TestBank(new FileSystemRepoFactory());
    }

    private void TestBank(IRepoFactory repoFactory)
    {
        var sut = new Bank(repoFactory);

        sut.CreateUser("Tom", 32);
        sut.CreateUser("Jane", 33);

        sut.CreateAccount("Tom", "Personal account");
        sut.CreateAccount("Tom", "Corporate account");

        var users = sut.GetUsers();
        users.Count.ShouldBe(2);
        users[1].Name.ShouldBe("Tom");
        users[1].Age.ShouldBe(32);

        users[0].Name.ShouldBe("Jane");
        users[0].Age.ShouldBe(33);

        var tomsAccounts = sut.GetAccounts("Tom");
        tomsAccounts.Count.ShouldBe(2);

        tomsAccounts[0].Username.ShouldBe("Tom");
        tomsAccounts[0].AccountName.ShouldBe("Corporate account");

        tomsAccounts[1].Username.ShouldBe("Tom");
        tomsAccounts[1].AccountName.ShouldBe("Personal account");

        var janesAccounts = sut.GetAccounts("Jane");
        janesAccounts.Count.ShouldBe(0);

        sut.Deposit("Tom", "Corporate account", 100);
        sut.GetBalance("Tom", "Corporate account").ShouldBe(100);

        sut.Transfer("Tom", "Corporate account", "Tom", "Personal account", 25);
        sut.GetBalance("Tom", "Corporate account").ShouldBe(75);
        sut.GetBalance("Tom", "Personal account").ShouldBe(25);
    }
}
