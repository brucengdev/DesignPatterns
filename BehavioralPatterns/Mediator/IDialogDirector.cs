using System.Collections.ObjectModel;

namespace Mediator;

public interface IDialogDirector
{
    ReadOnlyDictionary<string, Widget> Widgets { get; }
    void CreateWidgets();

    void WidgetChanged(Widget widget);
}