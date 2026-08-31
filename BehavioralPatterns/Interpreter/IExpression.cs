namespace Interpreter;

public interface IExpression
{
    bool Evaluate(Context context);
}