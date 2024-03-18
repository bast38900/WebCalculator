namespace WebCalculatorLib;

///
/// Represents a calculator that performs various basic mathematical operations.
///
public class BasicMathOperator: IBasicOperation
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
}
