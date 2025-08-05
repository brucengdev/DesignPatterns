namespace Mediator;

public class Tests
{
    [Fact]
    public void Test_dish_selector_dialog()
    {
        //arrange
        var director = new DishDialogDirector();
        director.CreateWidgets();

        var dishName = director.Widgets["DishName"] as TextField;
        var dishList = director.Widgets["DishList"] as ListField;
        var discountCheckbox = director.Widgets["Discount"] as Checkbox;
        
        //act
        dishList.Select("Pizza");
        
        //assert
        Assert.Equal("Pizza", dishName.Text);
        
    }
}