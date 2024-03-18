namespace WebCalculatorLib;

///
/// Represents a calculator that performs various advanced mathematical operations.
///
public class AdvancedMathOperator: IAdvancedOperation
{
    /// Calculates the modulus of the two numbers
    public double Modulus(double a, double b)
    {
        return a % b;
    }

    /// Raises the first number to the power of the second number
    public double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }

    /// Calculates the square root of the first number
    public double SquareRoot(double a)
    {
        return Math.Sqrt(a);
    }
}
