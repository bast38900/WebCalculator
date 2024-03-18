namespace WebCalculatorTests
{
    ///
    /// This class contains unit tests for the BasicMathOperator class.
    /// 
    public class BasicBasicMathOperatorTest
    {
        [Fact]
        public void AddNumbersTest_Success()
        {
            // Arrange
            var basicMathOperator = new BasicMathOperator();

            // Act
            var result = basicMathOperator.Add(1, 2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddNumbersTest_Fail()
        {
            // Arrange
            var basicMathOperator = new BasicMathOperator();

            // Act
            var result = basicMathOperator.Add(1, 4);
            // Assert
            Assert.NotEqual(3, result);
        }

        [Fact]
        public void SubtractNumbersTest_Success()
        {
            // Arrange
            var basicMathOperator = new BasicMathOperator();

            // Act
            var result = basicMathOperator.Subtract(4, 3);
            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void SubtractNumbersTest_Fail()
        {
            // Arrange
            var basicMathOperator = new BasicMathOperator();

            // Act
            var result = basicMathOperator.Subtract(4, 2);
            // Assert
            Assert.NotEqual(1, result);
        }

        [Fact]
        public void MultiplyNumbersTest_Success()
        {
            // Arrange
            var basicMathOperator = new BasicMathOperator();

            // Act
            var result = basicMathOperator.Multiply(4, 3);
            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void MultiplyNumbersTest_Fail()
        {
            // Arrange
            var basicMathOperator = new BasicMathOperator();

            // Act
            var result = basicMathOperator.Multiply(4, 3);
            // Assert
            Assert.NotEqual(10, result);
        }

        [Fact]
        public void DivideNumbersTest_Success()
        {
            // Arrange
            var basicMathOperator = new BasicMathOperator();

            // Act
            var result = basicMathOperator.Divide(4, 2);
            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void DivideNumbersTest_Fail()
        {
            // Arrange
            var basicMathOperator = new BasicMathOperator();

            // Act
            var result = basicMathOperator.Divide(6, 2);
            // Assert
            Assert.NotEqual(2, result);
        }
    }
}