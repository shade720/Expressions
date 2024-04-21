using Expressions.Models.Expressions;

namespace Expressions.Abstractions;

public interface IExpressionTransformer<out T>
{
    public T Transform(IntegerExpression integerExpression);
    public T Transform(DoubleExpression doubleExpression);
    public T Transform(AdditionalExpression additionalExpression);
    public T Transform(MultiplyExpression multiplyExpression);
}