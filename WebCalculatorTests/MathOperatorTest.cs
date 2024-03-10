namespace WebCalculatorTests
{
    public class MathOperatorTest
    {
        [Fact]
        public void AddNumbersTest_Succes()
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
        public void AddNumbersTest_Fail()
        {
            // Arrange
            var mathOperator = new MathOperator
            {
                num1 = "2",
                num2 = "2"
            };
            // Act
            mathOperator.AddNumbers();
            // Assert
            Assert.NotEqual("3", mathOperator.finalresult);
        }

        [Fact]
        public void SubtractNumbersTest_Succes()
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
        public void SubtractNumbersTest_Fail()
        {
            // Arrange
            var mathOperator = new MathOperator
            {
                num1 = "3",
                num2 = "3"
            };
            // Act
            mathOperator.SubtractNumbers();
            // Assert
            Assert.NotEqual("1", mathOperator.finalresult);
        }

        [Fact]
        public void MultiplyNumbersTest_Succes()
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
        public void MultiplyNumbersTest_Fail()
        {
            // Arrange
            var mathOperator = new MathOperator
            {
                num1 = "2",
                num2 = "2"
            };
            // Act
            mathOperator.MultiplyNumbers();
            // Assert
            Assert.NotEqual("6", mathOperator.finalresult);
        }

        [Fact]
        public void DivideNumbersTest_Succes()
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

        [Fact]
        public void DivideNumbersTest_Fail()
        {
            // Arrange
            var mathOperator = new MathOperator
            {
                num1 = "6",
                num2 = "6"
            };
            // Act
            mathOperator.DivideNumbers();
            // Assert
            Assert.NotEqual("3", mathOperator.finalresult);
        }
    }
}