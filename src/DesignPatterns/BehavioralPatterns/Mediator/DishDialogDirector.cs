using System.Collections.ObjectModel;

namespace Mediator;

public class DishDialogDirector: DialogDirector
{
    private Dictionary<string, Widget> _widgets = new();
    public override ReadOnlyDictionary<string, Widget> Widgets => new ReadOnlyDictionary<string, Widget>(_widgets);

    public override void CreateWidgets()
    {
        var dishName = new TextField("Dish Name", this);
        _widgets["DishName"] = dishName;
        var dishList = new ListField("Dish List", this);
        var discountCheckbox = new Checkbox("Discount", this);
    }
}