namespace Interpreter;

public class AndExpression: IExpression
{
    private IExpression _exp1, _exp2;
    public AndExpression(IExpression expression1, IExpression expression2)
    {
        _exp1 = expression1;
        _exp2 = expression2;
    }

    public bool Evaluate(Context context)
    {
        return _exp1.Evaluate(context) && _exp2.Evaluate(context);
    }
}