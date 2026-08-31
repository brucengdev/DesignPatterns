namespace Flyweight;

public class BaseCharacter: Character
{
    protected string[] data;
    public override void Render(char[,] buffer, int left, int top)
    {
        var y = top;
        for (int h = 0; h < HEIGHT; h++)
        {
            var x = left;

            for (int w = 0; w < WIDTH; w++)
            {
                buffer[y, x] = data[h][w];
                x++;
            }

            y++;
        }
    }
}