namespace RpnCalculator.Services.Operations;

public class SubtractOperation: IOperation
{
    public decimal Calculate(decimal firstValue, decimal secondValue)
    {
        return secondValue - firstValue;
    }
}