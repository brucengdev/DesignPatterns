namespace Singleton;

public abstract class Singleton
{
    private static Dictionary<string, Singleton> _instances = new();
    public static Singleton Instance()
    {
        //get the instance from an environment variable or config file
        var instanceName = "MySingleton";
        return _instances[instanceName];
    }

    public static void Register(Singleton instance, string name)
    {
        _instances[name] = instance;
    }

    public abstract string GetValue();
}

public class MySingleton : Singleton
{
    static MySingleton()
    {
        Register(new MySingleton(), "MySingleton");
    }

    public override string GetValue()
    {
        return "This is from MySingleton";
    }
}