using System.Text;

namespace Prototype;

public class Maze
{
    private MazeCell[,] _cells;

    public Maze(int width, int height)
    {
        _cells = new MazeCell[width, height];
    }

    internal string Render()
    {
        var sb = new StringBuilder();
        for(int y = 0; y < _cells.GetLength(0); y++)
        {
            for(int x = 0; x < _cells.GetLength(1); x++)
            {
                sb.Append(_cells[x, y].Character);
            }
            sb.Append(Environment.NewLine);
        }
        return sb.ToString();
    }

    internal void SetCell(MazeCell cell, int x, int y)
    {
        _cells[x, y] = cell;
    }
}