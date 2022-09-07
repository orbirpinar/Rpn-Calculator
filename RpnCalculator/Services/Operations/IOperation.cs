namespace RpnCalculator.Services.Operations;

public interface IOperation
{
    decimal Calculate(decimal firstValue, decimal secondValue);

}