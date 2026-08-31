namespace TemplateMethod;

public class WelcomingGreetingBuilder: BaseGreetingBuilder
{
    protected override string CreateGreeting(string name)
    {
        return $"Pleased to meet you, {name}\n";
    }

    protected override string CreateWelcomeMessage()
    {
        return "We are honored for your presence here today.\n";
    }

    protected override string CreateInfo(int age, string location)
    {
        return $"For a person of {age} years old from {location}, you are a key person in our group.\n";
    }
}