namespace Mediator;

public abstract class Control
{
    private IDialogDirector _director { get; }
    public Control(IDialogDirector director)
    {
        this._director = director;
    }

    public bool Enabled { get; set; } = true;

    protected void Updated()
    {
        _director.ControlUpdated(this);
    }
}