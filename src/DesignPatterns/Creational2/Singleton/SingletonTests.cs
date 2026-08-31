using Shouldly;

namespace Singleton;

public class SingletonTests
{
    [Fact]
    public void TestSingleton()
    {
        var instance = Greeter.Instance();
        var instance2 = Greeter.Instance();

        instance.ShouldBe(instance2);

        var greeting = instance.GetGreeting();
        greeting.ShouldBe("Greeting #1");

        greeting = instance.GetGreeting();
        greeting.ShouldBe("Greeting #2");

        greeting = instance.GetGreeting();
        greeting.ShouldBe("Greeting #3");
    }
}
