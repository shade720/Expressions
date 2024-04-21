using Expressions.Models.Expressions;
using Expressions.Models.Visitors;

var expression = new MultiplyExpression(
    new AdditionalExpression(
        new IntegerExpression(3),
        new IntegerExpression(4)),
    new AdditionalExpression(
        new DoubleExpression(14.0),
        new DoubleExpression(4.0)));

var printingVisitor = new ExpressionPrintingVisitor();
Console.WriteLine(printingVisitor.PrintExpression(expression));

var printingTransformer = new ExpressionPrintingTransformer();
Console.WriteLine(printingTransformer.PrintExpression(expression));

var squaredExpression = new SquareExpressionTransformer().GetSquaredExpression(expression);
Console.WriteLine(printingTransformer.PrintExpression(squaredExpression));

Console.WriteLine(new EvaluateExpressionTransformer().Evaluate(expression));
Console.WriteLine(new EvaluateExpressionTransformer().Evaluate(squaredExpression));