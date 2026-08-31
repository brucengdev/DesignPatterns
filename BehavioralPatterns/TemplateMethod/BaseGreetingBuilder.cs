using System.Text;

namespace TemplateMethod;

public abstract class BaseGreetingBuilder
{
    public string BuildGreeting(string name, int age, string location)
    {
        var sb = new StringBuilder();
        sb.Append(CreateGreeting(name));
        sb.Append(CreateInfo(age, location));
        sb.Append(CreateWelcomeMessage());
        return sb.ToString();
    }
    protected abstract string CreateGreeting(string name);
    protected abstract string CreateWelcomeMessage();
    protected abstract string CreateInfo(int age, string location);
}