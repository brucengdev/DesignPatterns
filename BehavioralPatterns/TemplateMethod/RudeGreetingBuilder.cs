namespace TemplateMethod;

public class RudeGreetingBuilder: BaseGreetingBuilder
{
    protected override string CreateGreeting(string name)
    {
        return $"Yo, {name}\n";
    }

    protected override string CreateWelcomeMessage()
    {
        return "Come join or get lost!\n";
    }

    protected override string CreateInfo(int age, string location)
    {
        return $"You're {age}, from {location}, not that I care.\n";
    }
}