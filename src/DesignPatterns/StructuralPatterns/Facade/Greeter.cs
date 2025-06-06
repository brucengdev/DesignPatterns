namespace Facade;

public class Greeter
{
    public object Greet(string name)
    {
        return $"Greeting, {name}!";
    }
}