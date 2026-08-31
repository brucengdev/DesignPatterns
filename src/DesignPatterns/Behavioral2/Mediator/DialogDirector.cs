namespace Mediator;

public class DialogDirector: IDialogDirector
{
    private DishSelectionDialog _dialog;
    public DialogDirector(DishSelectionDialog dialog)
    {
        _dialog = dialog;
    }

    public void ControlUpdated(Control control)
    {
        if (control == _dialog.DishSelector)
        {
            if (_dialog.DishSelector.Value == 0)//Pho
            {
                _dialog.NoodleOptionsSelector.Enabled = true;
            }
            else
            {
                _dialog.NoodleOptionsSelector.Enabled = false;
            }

            if (_dialog.DishSelector.Value == 0 || _dialog.DishSelector.Value == 1) //Pho or soup
            {
                _dialog.IncludeUtensils.Enabled = true;
            }
            else
            {
                _dialog.IncludeUtensils.Enabled = false;
            }
        }
    }
}