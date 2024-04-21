using Expressions.Abstractions;

namespace Expressions.Models.Expressions;

public class IntegerExpression : Expression
{
    public readonly int Value;

    public IntegerExpression(int value) => Value = value;

    public override void Accept(IExpressionVisitor visitor) => visitor.Visit(this);

    public override T Reduce<T>(IExpressionTransformer<T> expressionTransformer) => expressionTransformer.Transform(this);
}