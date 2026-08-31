namespace Interpreter;

public class BooleanExpressionTests
{
    [Fact]
    public void TestExpression()
    {
        //(true and x) or (y and not x)

        var x = new VariableExpression("x");
        var y = new VariableExpression("y");

        var expression = new OrExpression(
            new AndExpression(new ConstantExpression(true), x),
            new AndExpression(y, new NotExpression(x))
        );

        var context = new Context();
        context.Assign("x", false);
        context.Assign("y", true);
        
        Assert.True(expression.Evaluate(context));

        context.Assign("x", false);
        context.Assign("y", false);
        Assert.False(expression.Evaluate(context));
    }
}