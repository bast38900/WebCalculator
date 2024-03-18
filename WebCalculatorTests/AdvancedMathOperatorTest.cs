namespace WebCalculatorTests
{
  ///
  /// This class contains unit tests for the AdvancedMathOperator class.
  /// 
  public class AdvancedAdvancedMathOperatorTest
  {
    [Theory]
    [InlineData(9, 3)]
    [InlineData(16, 4)]
    [InlineData(25, 5)]
    public void SquareRootNumberTest_Success(double input, double expected)
    {
      // Arrange
      var AdvancedMathOperator = new AdvancedMathOperator();
  
      // Act
      var result = AdvancedMathOperator.SquareRoot(input);
      
      // Assert
      Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(9, 5)]
    [InlineData(16, 3)]
    [InlineData(25, 4)]
    public void SquareRootNumberTest_Fail(double input, double notExpected)
    {
      // Arrange
      var AdvancedMathOperator = new AdvancedMathOperator();
      
      // Act
      var result = AdvancedMathOperator.SquareRoot(input);
      
      // Assert
      Assert.NotEqual(notExpected, result);
    }

    [Theory]
    [InlineData(2, 3, 8)]
    [InlineData(3, 3, 27)]
    [InlineData(4, 3, 64)]
    public void PowerNumberTest_Success(double a, double b, double expected)
    {
      // Arrange
      var AdvancedMathOperator = new AdvancedMathOperator();
      
      // Act
      var result = AdvancedMathOperator.Power(a, b);
      
      // Assert
      Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 3, 9)]
    [InlineData(3, 3, 28)]
    [InlineData(4, 3, 65)]
    public void PowerNumberTest_Fail(double a, double b, double notExpected)
    {
      // Arrange
      var AdvancedMathOperator = new AdvancedMathOperator();
      
      // Act
      var result = AdvancedMathOperator.Power(a, b);
      
      // Assert
      Assert.NotEqual(notExpected, result);
    }

    [Theory]
    [InlineData(5, 2, 1)]
    [InlineData(7, 3, 1)]
    [InlineData(9, 4, 1)]
    public void ModulusNumbersTest_Success(double a, double b, double expected)
    {
      // Arrange
      var AdvancedMathOperator = new AdvancedMathOperator();
      
      // Act
      var result = AdvancedMathOperator.Modulus(a, b);
      
      // Assert
      Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 2, 2)]
    [InlineData(7, 3, 2)]
    [InlineData(9, 4, 2)]
    public void ModulusNumbersTest_Fail(double a, double b, double notExpected)
    {
      // Arrange
      var AdvancedMathOperator = new AdvancedMathOperator();
      
      // Act
      var result = AdvancedMathOperator.Modulus(a, b);
      
      // Assert
      Assert.NotEqual(notExpected, result);
    }
  }
}