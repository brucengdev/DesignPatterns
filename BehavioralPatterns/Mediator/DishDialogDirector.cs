using System.Collections.ObjectModel;

namespace Mediator;

public class DishDialogDirector: IDialogDirector
{
    private Dictionary<string, Widget> _widgets = new();
    private TextField _dishName;
    private ListField _dishList;
    private Checkbox _discount;
    public ReadOnlyDictionary<string, Widget> Widgets => new ReadOnlyDictionary<string, Widget>(_widgets);

    public void CreateWidgets()
    {
        _dishName = new TextField("Dish Name", this);
        _widgets["DishName"] = _dishName;
        
        _dishList = new ListField("Dish List", this);
        _dishList.AddItems("Pizza", "Ramen", "Sushi", "Burger");
        _widgets["DishList"] = _dishList;
        
        _discount = new Checkbox("Discount", this);
        _widgets["Discount"] = _discount;
    }

    public void WidgetChanged(Widget widget)
    {
        if (widget == _dishList && _dishList.SelectedOption != null)
        {
            _dishName.Text = _dishList.SelectedOption;
            if (_dishName.Text == "Burger" || _dishName.Text == "Pizza")
            {
                _discount.Checked = true;
            }
        }

        if (widget == _dishName && _dishName.Text != null)
        {
            _dishList.Select(_dishName.Text);
        }
    }
}