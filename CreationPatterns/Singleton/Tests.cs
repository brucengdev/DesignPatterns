namespace Singleton;
public class Tests
{
    [Fact]
    public void Test1()
    {
        //currently, MySingleton's static constructor is not triggered
        //so this test is failing.
        var instance = Singleton.Instance();
        
        Assert.Equal("This is from MySingleton", instance.GetValue());
    }
}