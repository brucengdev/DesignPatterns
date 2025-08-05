using System.Collections.ObjectModel;

namespace Mediator;

public abstract class DialogDirector
{
    public abstract ReadOnlyDictionary<string, Widget> Widgets { get; }
    public abstract void CreateWidgets();

    public abstract void WidgetChanged(Widget widget);
}