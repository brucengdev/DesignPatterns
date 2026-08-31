namespace Flyweight;

public class Program
{
    public static void Main(string[] args)
    {
        var characterFactory = new CharacterFactory();
        var text = "AABBCDD";
        var textRenderer = new TextRenderer(characterFactory, text);

        textRenderer.Render();
    }
}