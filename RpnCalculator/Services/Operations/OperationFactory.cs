namespace RpnCalculator.Services.Operations;

public class OperationFactory
{
    private static readonly Dictionary<string, Func<IOperation>> Operations = new()
    {
        {OperationType.Plus,() => new AddOperation()},
        {OperationType.Minus,() => new SubtractOperation()},
        {OperationType.Mulipllication,() => new MultiplyOperation()},
        {OperationType.Division,() => new DivideOperation()}
    };

    public static IOperation Get(string sign)
    {
        return Operations[sign]();
    }
}