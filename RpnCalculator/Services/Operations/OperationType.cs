namespace RpnCalculator.Services.Operations;

public class OperationType
{
    public static readonly string Plus = "+";
    public static readonly string Minus = "-";
    public static readonly string Mulipllication = "*";
    public static readonly string Division = "/";

    public static List<string> GetAll()
    {
        return new List<string>
        {
            Plus, Minus, Mulipllication, Division
        };
    }
}