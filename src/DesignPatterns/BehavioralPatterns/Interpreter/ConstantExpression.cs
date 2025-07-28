namespace Interpreter;

public class ConstantExpression: IExpression
{
    private bool _value = false;
    public ConstantExpression(bool value)
    {
        _value = value;
    }

    public bool Evaluate(Context context)
    {
        return _value;
    }
}