namespace Facade;

public class Tests
{
    [Fact]
    public void UsingSubsystem()
    {
        var greeter = new Greeter();
        var greeting = greeter.Greet("John");

        var weightCalculator = new WeightCalculator();
        var weight = weightCalculator.CalculateIdealWeight(165);

        var info = $"{greeting} Your ideal weight is {weight} kg.";
        Assert.Equal("Greeting, John! Your ideal weight is 65 kg.", info);
    }

    [Fact]
    public void UsingFacade()
    {
        var healthInfoBuilder = new HealthInfoBuilder();

        var info = CreateHealthInfo(healthInfoBuilder);
        Assert.Equal("Greeting, John! Your ideal weight is 65 kg.", info);
    }

    /// <summary>
    /// The following method is an example of client code using the Facade
    /// The IHealthInfoBuilder provides a simpler interface than using Greeter and WeightCalculator
    /// separately.
    /// </summary>
    /// <param name="healthInfoBuilder"></param>
    /// <returns></returns>
    private string CreateHealthInfo(IHealthInfoBuilder healthInfoBuilder)
    {
        return healthInfoBuilder.BuildInfo("John", 165);
    }
}
