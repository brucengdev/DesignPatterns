namespace Mediator;

public class Tests
{
    [Fact]
    public void Select_western_dish_by_list_field()
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
        Assert.False(discountCheckbox.Enabled);//no discount for western dishes
    }
}