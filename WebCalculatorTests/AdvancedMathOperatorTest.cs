namespace WebCalculatorTests
{
    ///
    /// This class contains unit tests for the AdvancedMathOperator class.
    /// 
    public class AdvancedAdvancedMathOperatorTest
    {
        [Fact]
        public void SquareRootNumberTest_Success()
        {
            // Arrange
            var AdvancedMathOperator = new AdvancedMathOperator();
    
            
            // Act
            var result = AdvancedMathOperator.SquareRoot(9);
            
            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void SquareRootNumberTest_Fail()
        {
            // Arrange
            var AdvancedMathOperator = new AdvancedMathOperator();
            
            // Act
             var result = AdvancedMathOperator.SquareRoot(9);
            
            // Assert
            Assert.NotEqual(5, result);
        }
    }
}