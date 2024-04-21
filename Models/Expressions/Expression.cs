using Expressions.Abstractions;

namespace Expressions.Models.Expressions;

public abstract class Expression
{
    public abstract void Accept(IExpressionVisitor visitor);
    public abstract T Reduce<T>(IExpressionTransformer<T> expressionTransformer);
}