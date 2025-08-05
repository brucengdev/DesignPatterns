namespace Mediator;

public class Tests
{
    [Fact]
    public void Test1()
    {
        var director = new DishDialogDirector();
        var dishName = new TextField("Dish Name", director);
    }
}