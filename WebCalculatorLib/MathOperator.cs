namespace WebCalculatorLib;

///
/// Represents a math operator that performs various mathematical operations.
/// 
public class MathOperator
{
    /// 
    /// Adds the two numbers
    ///
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

    // ///
    // /// Calculates the modulus of the first number divided by the second number and stores the result in the <see cref="finalresult"/> property.
    // ///
    // public void ModulusNumbers()
    // {
    //     finalresult = (Convert.ToDouble(num1) % Convert.ToDouble(num2)).ToString();
    // }

    // /// 
    // /// Raises the first number to the power of the second number and stores the result in the <see cref="finalresult"/> property.
    // ///
    // public void PowerNumbers()
    // {
    //     finalresult = Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2)).ToString();
    // }

    // /// 
    // /// Calculates the square root of the first number and stores the result in the <see cref="finalresult"/> property.
    // ///
    // public void SquareRootNumber()
    // {
    //     finalresult = Math.Sqrt(Convert.ToDouble(num1)).ToString();
    // }
}
