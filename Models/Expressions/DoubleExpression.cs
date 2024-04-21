using Expressions.Abstractions;

namespace Expressions.Models.Expressions;

public class DoubleExpression : Expression
{
    public readonly double Value;

    public DoubleExpression(double value) => Value = value;

    public override void Accept(IExpressionVisitor visitor) => visitor.Visit(this);

    public override T Reduce<T>(IExpressionTransformer<T> expressionTransformer) => expressionTransformer.Transform(this);
}