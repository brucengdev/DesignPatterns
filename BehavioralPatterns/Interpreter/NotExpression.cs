namespace Interpreter;

public class NotExpression: IExpression
{
    private IExpression _subExp;
    public NotExpression(VariableExpression subExp)
    {
        _subExp = subExp;
    }

    public bool Evaluate(Context context)
    {
        return !_subExp.Evaluate(context);
    }
}