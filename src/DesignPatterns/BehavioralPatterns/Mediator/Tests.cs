namespace Mediator;

public class Tests
{
    [Theory]
    [InlineData("Pizza", true)]//discount for western dishes
    [InlineData("Burger", true)]
    [InlineData("Sushi", false)]
    [InlineData("Ramen", false)]
    public void Verify_dish_selection_by_list_field(string dish, bool shouldDiscount)
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
        Assert.Equal(shouldDiscount, discountCheckbox.Checked);//no discount for western dishes
    }
    
    [Theory]
    [InlineData("Pizza", true)]//discount for western dishes
    [InlineData("Burger", true)]
    [InlineData("Sushi", false)]
    [InlineData("Ramen", false)]
    public void Verify_dish_selection_by_text_field(string dish, bool shouldDiscount)
    {
        //arrange
        var director = new DishDialogDirector();
        director.CreateWidgets();

        var dishName = director.Widgets["DishName"] as TextField;
        var dishList = director.Widgets["DishList"] as ListField;
        var discountCheckbox = director.Widgets["Discount"] as Checkbox;
        
        //act
        dishName.Text = dish;
        
        //assert
        Assert.Equal(dish, dishList.SelectedOption);
        Assert.Equal(shouldDiscount, discountCheckbox.Checked);//no discount for western dishes
    }
}