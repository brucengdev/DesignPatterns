namespace Singleton;
using Shouldly;
public class Tests
{
    [Fact]
    public void Test1()
    {
        //currently, MySingleton's static constructor is not triggered
        //so this test is failing.
        var instance = Singleton.Instance();
        
        instance.GetValue().ShouldBe("This is from MySingleton");
    }
}