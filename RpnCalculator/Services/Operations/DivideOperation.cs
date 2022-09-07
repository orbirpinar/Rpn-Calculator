namespace RpnCalculator.Services.Operations;

public class DivideOperation: IOperation
{
    public decimal Calculate(decimal firstValue, decimal secondValue)
    {
        return secondValue / firstValue;
    }

}