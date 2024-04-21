using Expressions.Abstractions;
using Expressions.Models.Expressions;

namespace Expressions.Models.Visitors;

public class ExpressionPrintingTransformer : IExpressionTransformer<string>
{
    public string PrintExpression(Expression expression) => expression.Reduce(this);

    public string Transform(IntegerExpression integerExpression) => integerExpression.Value.ToString();

    public string Transform(DoubleExpression doubleExpression) => doubleExpression.Value.ToString("F1");

    public string Transform(AdditionalExpression additionalExpression)
    {
        return $"({additionalExpression.LeftOperand.Reduce(this)} + {additionalExpression.RightOperand.Reduce(this)})";
    }

    public string Transform(MultiplyExpression multiplyExpression)
    {
        return $"({multiplyExpression.LeftOperand.Reduce(this)} * {multiplyExpression.RightOperand.Reduce(this)})";
    }
}