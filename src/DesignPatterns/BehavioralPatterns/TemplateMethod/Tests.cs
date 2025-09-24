using Shouldly;

namespace TemplateMethod;

public class Tests
{
    [Fact]
    public void TestRudeGreeting()
    {
        var builder = new RudeGreetingBuilder();

        var greeting = builder.BuildGreeting("Tam", 32, "Hanoi");

        greeting.ShouldBe("Yo, Tam\nYou're 32, from Hanoi, not that I care.\nCome join or get lost!\n");
    }
    
    [Fact]
    public void TestWelcomingGreeting()
    {
        var builder = new WelcomingGreetingBuilder();

        var greeting = builder.BuildGreeting("Tam", 32, "Hanoi");

        greeting.ShouldBe("Pleased to meet you, Tam\n"+
                          "For a person of 32 years old from Hanoi, you are a key person in our group.\n"+
                          "We are honored for your presence here today.\n");
    }
}