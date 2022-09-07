using Microsoft.AspNetCore.Mvc;
using RpnCalculator.Contracts.Request;
using RpnCalculator.Contracts.Response;
using RpnCalculator.Services;

namespace RpnCalculator.Controllers;

[ApiController]
[Route("/api/v1")]
public class RpnCalculatorController : ControllerBase
{


    private readonly ILogger<RpnCalculatorController> _logger;
    private readonly ICalculatorService _calculatorService;

    public RpnCalculatorController(ILogger<RpnCalculatorController> logger, ICalculatorService calculatorService)
    {
        _logger = logger;
        _calculatorService = calculatorService;
    }

    [HttpPost("calculate")]
    public CalculatorResponse Get(RpnCalculatorRequest request)
    {
        _logger.LogInformation("Calculate endpoint called..");
        return _calculatorService.Calculate(request);
    }
}
