namespace Mediator;

public class DishDialogDirector: DialogDirector
{
    public override void CreateWidgets()
    {
        var dishName = new TextField("Dish Name", this);
        var dishList = new ListField("Dish List", this);
        var discountCheckbox = new Checkbox("Discount", this);
    }
}