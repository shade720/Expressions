using System.Text;
using Expressions.Abstractions;
using Expressions.Models.Expressions;

namespace Expressions.Models.Visitors;

public class ExpressionPrintingVisitor : IExpressionVisitor
{
    private StringBuilder? _stringBuilder;

    public string PrintExpression(Expression expression)
    {
        _stringBuilder = new StringBuilder();
        expression.Accept(this);
        return _stringBuilder.ToString();
    }

    public void Visit(IntegerExpression integerExpression)
    {
        _stringBuilder?.Append(integerExpression.Value);
    }

    public void Visit(DoubleExpression doubleExpression)
    {
        _stringBuilder?.Append(doubleExpression.Value.ToString("F1"));
    }

    public void Visit(AdditionalExpression additionalExpression)
    {
        _stringBuilder?.Append("(");
        additionalExpression.LeftOperand.Accept(this);
        _stringBuilder?.Append(" + ");
        additionalExpression.RightOperand.Accept(this);
        _stringBuilder?.Append(")");
    }

    public void Visit(MultiplyExpression multiplyExpression)
    {
        _stringBuilder?.Append("(");
        multiplyExpression.LeftOperand.Accept(this);
        _stringBuilder?.Append(" * ");
        multiplyExpression.RightOperand.Accept(this);
        _stringBuilder?.Append(")");
    }
}