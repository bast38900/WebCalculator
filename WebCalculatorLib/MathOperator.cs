namespace WebCalculatorLib;

///
/// Represents a calculator that performs various mathematical operations.
///
public class MathOperator
{
    /// Adds the two numbers
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Method to subtract two numbers
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    // Method to multiply two numbers
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    // Method to divide two numbers
    public double Divide(double a, double b)
    {
        return a / b;
    }

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
