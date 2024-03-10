namespace WebCalculatorTests
{
    public class MathOperatorTest
    {
        [Fact]
        public void AddNumbersTest()
        {
            // Arrange
            var mathOperator = new MathOperator
            {
                num1 = "1",
                num2 = "2"
            };
            // Act
            mathOperator.AddNumbers();
            // Assert
            Assert.Equal("3", mathOperator.finalresult);
        }

        [Fact]
        public void SubtractNumbersTest()
        {
            // Arrange
            var mathOperator = new MathOperator
            {
                num1 = "3",
                num2 = "2"
            };
            // Act
            mathOperator.SubtractNumbers();
            // Assert
            Assert.Equal("1", mathOperator.finalresult);
        }

        [Fact]
        public void MultiplyNumbersTest()
        {
            // Arrange
            var mathOperator = new MathOperator
            {
                num1 = "3",
                num2 = "2"
            };
            // Act
            mathOperator.MultiplyNumbers();
            // Assert
            Assert.Equal("6", mathOperator.finalresult);
        }

        [Fact]
        public void DivideNumbersTest()
        {
            // Arrange
            var mathOperator = new MathOperator
            {
                num1 = "6",
                num2 = "2"
            };
            // Act
            mathOperator.DivideNumbers();
            // Assert
            Assert.Equal("3", mathOperator.finalresult);
        }
    }
}