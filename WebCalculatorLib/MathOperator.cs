namespace WebCalculatorLib;

///
/// Represents a math operator that performs various mathematical operations.
/// 
public class MathOperator
{
    public string? num1;
    public string? num2;
    public string? finalresult;

    /// 
    /// Adds the two numbers and stores the result in the <see cref="finalresult"/> property.
    ///
    public void AddNumbers()
    {
        finalresult = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
    }

    /// 
    /// Subtracts the second number from the first number and stores the result in the <see cref="finalresult"/> property.
    /// 
    public void SubtractNumbers()
    {
        finalresult = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
    }

    /// 
    /// Multiplies the two numbers and stores the result in the <see cref="finalresult"/> property.
    /// 
    public void MultiplyNumbers()
    {
        finalresult = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
    }

    /// 
    /// Divides the first number by the second number and stores the result in the <see cref="finalresult"/> property.
    /// If the second number is zero, sets the <see cref="finalresult"/> property to "Cannot Divide by Zero".
    /// 
    public void DivideNumbers()
    {
        if (Convert.ToDouble(num2) != 0)
        {
            finalresult = (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
        }
        else
        {
            finalresult = "Cannot Divide by Zero";
        }
    }

    ///
    /// Calculates the modulus of the first number divided by the second number and stores the result in the <see cref="finalresult"/> property.
    ///
    public void ModulusNumbers()
    {
        finalresult = (Convert.ToDouble(num1) % Convert.ToDouble(num2)).ToString();
    }

    /// 
    /// Raises the first number to the power of the second number and stores the result in the <see cref="finalresult"/> property.
    ///
    public void PowerNumbers()
    {
        finalresult = Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2)).ToString();
    }

    /// 
    /// Calculates the square root of the first number and stores the result in the <see cref="finalresult"/> property.
    ///
    public void SquareRootNumber()
    {
        finalresult = Math.Sqrt(Convert.ToDouble(num1)).ToString();
    }
}
