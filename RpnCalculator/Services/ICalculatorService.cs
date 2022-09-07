using RpnCalculator.Contracts.Request;
using RpnCalculator.Contracts.Response;

namespace RpnCalculator.Services;

public interface ICalculatorService
{
    CalculatorResponse Calculate(RpnCalculatorRequest rpnCalculatorRequest);
}