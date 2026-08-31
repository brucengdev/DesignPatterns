namespace Interpreter;

public class VariableExpression: IExpression
{
    private string _name;
    public VariableExpression(string name)
    {
        _name = name;
    }

    public bool Evaluate(Context context)
    {
        return context.GetValue(_name);
    }
}