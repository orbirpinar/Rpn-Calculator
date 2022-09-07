namespace RpnCalculator.Services.Operations;

public class MultiplyOperation: IOperation
{
    public decimal Calculate(decimal firstValue, decimal secondValue)
    {
        return secondValue * firstValue;
    }

}