namespace Interpreter;

public class OrExpression: IExpression
{
    private IExpression _exp1, _exp2;
    public OrExpression(IExpression exp1, IExpression exp2)
    {
        _exp1 = exp1;
        _exp2 = exp2;
    }

    public bool Evaluate(Context context)
    {
        return _exp1.Evaluate(context) || _exp2.Evaluate(context);
    }
}