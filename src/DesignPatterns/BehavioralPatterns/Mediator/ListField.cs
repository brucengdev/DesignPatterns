namespace Mediator;

public class ListField: Widget
{
    private string[] _options = [];
    private string? _selectedOption = null;
    private DialogDirector _director;

    public string? SelectedOption => _selectedOption;
    
    public ListField(string label, DialogDirector director)
    {
        _director = director;
    }

    public void AddItems(params string[] options)
    {
        _options = options;
    }

    public void Select(string option)
    {
        if (!_options.Contains(option))
        {
            throw new ArgumentException("Option not found in the list.", nameof(option));
        }

        if (_selectedOption == option)
        {
            return;
        }

        _selectedOption = option;
        _director.WidgetChanged(this);
    }
}