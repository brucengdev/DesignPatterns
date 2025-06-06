namespace Facade;

public class HealthInfoBuilder: IHealthInfoBuilder
{
    public string BuildInfo(string name, int height)
    {
        var greeter = new Greeter();
        var weightCalculator = new WeightCalculator();
        return $"{greeter.Greet(name)} Your ideal weight is {weightCalculator.CalculateIdealWeight(height)} kg.";
    }
}