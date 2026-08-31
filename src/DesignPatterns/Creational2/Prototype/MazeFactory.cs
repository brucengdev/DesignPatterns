using Microsoft.VisualBasic;

namespace Prototype;

public class MazeFactory
{
    private MazeCell _wallPrototype;
    private MazeCell _roomPrototype;
    private MazeCell _doorPrototype;

    internal Maze CreateMaze()
    {
        var maze = new Maze(10, 10);
        int[][] data = [
            [0 ,0 ,0, 0, 0, 0, 0, 0, 0, 0],
            [0 ,1 ,1, 1, 1, 1, 0, 0, 0, 0],
            [0 ,1 ,0, 0, 0, 1, 0, 0, 0, 0],
            [0 ,1 ,0, 0, 1, 1, 0, 0, 0, 0],
            [0 ,1 ,0, 0, 1, 0, 0, 0, 0, 0],
            [0 ,1 ,0, 0, 2, 0, 0, 0, 0, 0],
            [0 ,1 ,0, 0, 1, 0, 1, 2, 1, 0],
            [0 ,1 ,0, 0, 1, 0, 1, 0, 1, 0],
            [0 ,1 ,1, 2, 1, 0, 1, 0, 1, 1],
            [0 ,0 ,0, 0, 0, 0, 0, 0, 0, 0]
        ];
        for(int y= 0; y < 10; y++)
        {
            for(int x = 0; x < 10; x++)
            {
                MazeCell cell;
                switch(data[y][x])
                {
                    case 1: cell = _wallPrototype.Clone(); break;
                    case 2: cell = _doorPrototype.Clone(); break;
                    case 0:
                    default: cell = _roomPrototype.Clone(); break;

                }
                maze.SetCell(cell, x, y);
            }
        }
        return maze;
    }

    internal void RegisterDoor(MazeCell prototype)
    {
        _doorPrototype = prototype;
    }

    internal void RegisterRoom(MazeCell prototype)
    {
        _roomPrototype = prototype;
    }

    internal void RegisterWall(MazeCell prototype)
    {
        _wallPrototype = prototype;
    }
}