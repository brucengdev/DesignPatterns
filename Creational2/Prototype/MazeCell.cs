namespace Prototype;

public class MazeCell
{
    public bool Walkable = true;
    public char Character = ' ';

    public MazeCell Clone()
    {
        return new()
        {
            Walkable = this.Walkable,
            Character = this.Character
        };
    }
}