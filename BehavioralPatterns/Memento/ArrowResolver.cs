namespace Memento;

public class ArrowMemento
{
    private int _arrowX, _arrowY;

    public ArrowMemento(int arrowX, int arrowY)
    {
        _arrowX = arrowX;
        _arrowY = arrowY;
    }

    //Making ArrowResolver a nested class allows it to access private members of ArrowMemento
    //while hiding ArrowMemento's internals from other classes.
    //In C++, you can use friend classes for similar functionality.
    public class ArrowResolver
    {
        private Furniture _target;
        private int _arrowX, _arrowY;

        public ArrowResolver(Furniture target)
        {
            _target = target;
        }

        public void ResolveArrow(int? deltaX = null, int? deltaY = null)
        {
            if(deltaX != null && deltaY != null)
            {
                _target.Arrow.X = -deltaX.Value;
                _target.Arrow.Y = -deltaY.Value;
                return;
            }
            _target.Arrow.X = _arrowX; //arrow points to the opposite direction of the movement
            _target.Arrow.Y = _arrowY;
        }

        public ArrowMemento CreateMemento()
        {
            return new ArrowMemento(_target.Arrow.X, _target.Arrow.Y);
        }

        public void SetState(ArrowMemento state)
        {
            _arrowX = state._arrowX;
            _arrowY = state._arrowY;
        }
    }
}