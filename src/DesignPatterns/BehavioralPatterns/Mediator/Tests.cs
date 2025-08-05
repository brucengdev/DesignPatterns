namespace Mediator;

public class Tests
{
    [Fact]
    public void Test_dish_selector_dialog()
    {
        var director = new DishDialogDirector();
        var dishName = new TextField("Dish Name", director);
        var dishList = new ListField("Dish List", director);

        var discountCheckbox = new Checkbox("Discount", director);
    }
}