namespace Singleton;
using Shouldly;
public class Tests
{
    [Fact]
    public void Test1()
    {
        var instance = Singleton.Instance();
        
        instance.GetValue().ShouldBe("This is from MySingleton");
    }
}