namespace Mediator;

public class Tests
{
    [Theory]
    [InlineData("Pizza", false)]
    [InlineData("Burger", false)]
    public void Select_western_dish_by_list_field(string dish, bool shouldDiscount)
    {
        //arrange
        var director = new DishDialogDirector();
        director.CreateWidgets();

        var dishName = director.Widgets["DishName"] as TextField;
        var dishList = director.Widgets["DishList"] as ListField;
        var discountCheckbox = director.Widgets["Discount"] as Checkbox;
        
        //act
        dishList.Select(dish);
        
        //assert
        Assert.Equal(dish, dishName.Text);
        Assert.Equal(shouldDiscount, discountCheckbox.Enabled);//no discount for western dishes
    }
}