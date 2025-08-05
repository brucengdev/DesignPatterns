namespace Mediator;

public class Tests
{
    [Fact]
    public void Test_dish_selector_dialog()
    {
        var director = new DishDialogDirector();
        director.CreateWidgets();

        var dishName = director.Widgets["DishName"] as TextField;
        var dishList = director.Widgets["DishList"] as ListField;
        var checkBox = director.Widgets["Discount"] as Checkbox;
    }
}