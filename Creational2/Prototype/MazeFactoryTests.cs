namespace Prototype;

public class MazeFactoryTests
{
    [Fact]
    public async Task TestCreateMaze()
    {
        //arrange
        var mazeFactory = new MazeFactory();
        mazeFactory.RegisterWall(new MazeCell
        {
            Walkable = false,
            Character = 'X'
        });
        mazeFactory.RegisterRoom(new MazeCell
        {
            Walkable = true,
            Character = ' '
        });
        mazeFactory.RegisterDoor(new MazeCell
        {
            Walkable = true,
            Character = '='
        });

        //act
        var maze = mazeFactory.CreateMaze();

        //assert
        await Verifier.Verify(maze.Render());
    }
}
