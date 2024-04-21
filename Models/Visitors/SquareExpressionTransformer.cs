using Expressions.Abstractions;
using Expressions.Models.Expressions;

namespace Expressions.Models.Visitors;

public class SquareExpressionTransformer : IExpressionTransformer<Expression>
{
    public Expression GetSquaredExpression(Expression expression)
    {
        return expression.Reduce(this);
    }

    public Expression Transform(IntegerExpression integerExpression)
    {
        return new IntegerExpression(integerExpression.Value * integerExpression.Value);
    }

    public Expression Transform(DoubleExpression doubleExpression)
    {
        return new DoubleExpression(doubleExpression.Value * doubleExpression.Value);
    }

    public Expression Transform(AdditionalExpression additionalExpression)
    {
        return new AdditionalExpression(additionalExpression.LeftOperand.Reduce(this), additionalExpression.RightOperand.Reduce(this));
    }

    public Expression Transform(MultiplyExpression multiplyExpression)
    {
        return new MultiplyExpression(multiplyExpression.LeftOperand.Reduce(this), multiplyExpression.RightOperand.Reduce(this));
    }
}