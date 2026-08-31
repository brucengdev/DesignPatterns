namespace Mediator;

public class DishSelectionDialog
{
    private IDialogDirector _director;
    private TextView _priceView;
    public TextView PriceView => _priceView;

    private DropDownList _dishSelector;
    public DropDownList DishSelector => _dishSelector;

    private Selector _noodleOptionsSelector;
    public Selector NoodleOptionsSelector => _noodleOptionsSelector;

    private Checkbox _includeUtensils;
    public Checkbox IncludeUtensils => _includeUtensils;
    
    public DishSelectionDialog()
    {
        _director = new DialogDirector(this);
        
        _priceView = new TextView("Price", "", _director);
        _dishSelector = new DropDownList("Dish", ["Pho", "Soup", "Burger", "Pizza"], _director);
        _noodleOptionsSelector = new Selector("Noodles", ["More", "Less", "Normal"], _director);
        _includeUtensils = new Checkbox("Include utensils?", false, _director);
    }
}