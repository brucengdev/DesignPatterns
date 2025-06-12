namespace Flyweight;

public class TextRenderer(CharacterFactory characterFactory, string text)
{
    public void Render()
    {
        var width = Character.WIDTH * text.Length;
        var height = Character.HEIGHT;
        var buffer = new char[height, width];
        int left = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            var charFlyweight = characterFactory.GetCharacter(ch);
            //extrinsic state: x/y position.
            //intrinsic state: the rendering
            charFlyweight.Render(buffer, left, 0);
            left += Character.WIDTH;
        }

        PrintBuffer(buffer);
    }

    private void PrintBuffer(char[,] buffer)
    {
        for (int y = 0; y < buffer.GetLength(0); y++)
        {
            for (int x = 0; x < buffer.GetLength(1); x++)
            {
                Console.Write(buffer[y,x]);
            }
            Console.WriteLine();
        }
    }
}