using System.Globalization;
using RpnCalculator.Contracts.Request;
using RpnCalculator.Contracts.Response;
using RpnCalculator.Services.Operations;

namespace RpnCalculator.Services;

public class CalculatorService : ICalculatorService
{
    public CalculatorResponse Calculate(RpnCalculatorRequest rpnCalculatorRequest)
    {
        var expression = rpnCalculatorRequest.Expression;
        var expressionArray = expression.Split(" ");
        var stackExpression = new Stack<string>();
        foreach (var current in expressionArray)
        {
            if (IsOperationSign(current))
            {
                var operation = OperationFactory.Get(current);
                var first = ToDecimal(stackExpression.Pop());
                var second = ToDecimal(stackExpression.Pop());
                var result = operation.Calculate(first, second);
                stackExpression.Push(result.ToString(CultureInfo.CurrentCulture));
            }
            else
            {
                stackExpression.Push(current);
            }
        }

        return new CalculatorResponse(ToDecimal(stackExpression.Pop()));
    }

    private static decimal ToDecimal(string strValue)
    {
        if (decimal.TryParse(strValue, out var value))
        {
            return value;
        }
        throw new InvalidCastException($"Error when converting string to decimal invalid value {strValue}");
    }

    private static bool IsOperationSign(string strValue)
    {
        return OperationType.GetAll().Any(s => s.Equals(strValue));
    }
}