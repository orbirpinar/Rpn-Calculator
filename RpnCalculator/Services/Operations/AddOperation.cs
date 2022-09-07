namespace RpnCalculator.Services.Operations;

public class AddOperation: IOperation
{
    public decimal Calculate(decimal firstValue, decimal secondValue)
    {
        return secondValue + firstValue;
    }

    public string Sign => "+";
}