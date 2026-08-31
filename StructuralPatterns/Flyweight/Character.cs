namespace Flyweight;

public abstract class Character
{
    public const int WIDTH = 5;
    public const int HEIGHT = 5;

    public abstract void Render(char[,] buffer, int left, int i);
}