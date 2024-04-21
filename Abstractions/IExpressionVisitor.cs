using Expressions.Models.Expressions;

namespace Expressions.Abstractions;

public interface IExpressionVisitor
{
    public void Visit(IntegerExpression integerExpression);
    public void Visit(DoubleExpression doubleExpression);
    public void Visit(AdditionalExpression additionalExpression);
    public void Visit(MultiplyExpression multiplyExpression);
}