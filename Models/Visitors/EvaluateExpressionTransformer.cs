using Expressions.Abstractions;
using Expressions.Models.Expressions;

namespace Expressions.Models.Visitors;

public class EvaluateExpressionTransformer : IExpressionTransformer<double>
{
    public double Evaluate(Expression expression)
    {
        return expression.Reduce(this);
    }

    public double Transform(IntegerExpression integerExpression)
    {
        return integerExpression.Value;
    }

    public double Transform(DoubleExpression doubleExpression)
    {
        return doubleExpression.Value;
    }

    public double Transform(AdditionalExpression additionalExpression)
    {
        return additionalExpression.LeftOperand.Reduce(this) + additionalExpression.RightOperand.Reduce(this);
    }

    public double Transform(MultiplyExpression multiplyExpression)
    {
        return multiplyExpression.LeftOperand.Reduce(this) * multiplyExpression.RightOperand.Reduce(this);
    }
}