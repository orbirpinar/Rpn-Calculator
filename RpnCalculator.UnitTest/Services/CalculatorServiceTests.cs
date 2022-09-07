using RpnCalculator.Contracts.Request;
using RpnCalculator.Services;
using Xunit;

namespace RpnCalculator.UnitTest.Services;

public class CalculatorServiceTests
{
    private readonly CalculatorService _sut = new CalculatorService();
    
    
        
    [Theory]
    [InlineData("3 5 8 * 7 + *","141")]
    [InlineData("4 2 /","2")]
    [InlineData("4 2 + 3 -","3")]
    public void calculate_shouldReturnValidResult_WhenGivenRequestIsValid(string expression,string expectedResult)
    {
        
        // Arrange
        var request = new RpnCalculatorRequest(expression);
        
        // Act
        var actualResult = _sut.Calculate(request);
        var expected = decimal.Parse(expectedResult);
        // Assert
        Assert.Equal(expected,actualResult.Result);
        
    }


}