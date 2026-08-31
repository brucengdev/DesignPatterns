public class Greeter
{
    private static Greeter _instance = null;
    public static Greeter Instance()
    {
        if(_instance == null)
        {
            _instance = new();
        }
        return _instance;
    }

    private int _greetingCount = 1;

    public string GetGreeting()
    {
        return $"Greeting #{_greetingCount++}";
    }
}