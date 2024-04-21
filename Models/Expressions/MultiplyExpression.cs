using Expressions.Abstractions;

namespace Expressions.Models.Expressions;

public class MultiplyExpression : Expression
{
    public readonly Expression LeftOperand;
    public readonly Expression RightOperand;

    public MultiplyExpression(Expression leftOperand, Expression rightOperand)
    {
        LeftOperand = leftOperand;
        RightOperand = rightOperand;
    }

    public override void Accept(IExpressionVisitor visitor) => visitor.Visit(this);

    public override T Reduce<T>(IExpressionTransformer<T> expressionTransformer) => expressionTransformer.Transform(this);
}