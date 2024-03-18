namespace WebCalculatorTests
{
    ///
    /// This class contains unit tests for the MathOperator class.
    /// 
    public class MathOperatorTest
    {
        [Fact]
        public void AddNumbersTest_Success()
        {
            // Arrange
            var mathOperator = new MathOperator();

            // Act
            var result = mathOperator.Add(1, 2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddNumbersTest_Fail()
        {
            // Arrange
            var mathOperator = new MathOperator();

            // Act
            var result = mathOperator.Add(1, 4);
            // Assert
            Assert.NotEqual(3, result);
        }

        [Fact]
        public void SubtractNumbersTest_Success()
        {
            // Arrange
            var mathOperator = new MathOperator();

            // Act
            var result = mathOperator.Subtract(4, 3);
            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void SubtractNumbersTest_Fail()
        {
            // Arrange
            var mathOperator = new MathOperator();

            // Act
            var result = mathOperator.Subtract(4, 2);
            // Assert
            Assert.NotEqual(1, result);
        }

        [Fact]
        public void MultiplyNumbersTest_Success()
        {
            // Arrange
            var mathOperator = new MathOperator();

            // Act
            var result = mathOperator.Multiply(4, 3);
            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void MultiplyNumbersTest_Fail()
        {
            // Arrange
            var mathOperator = new MathOperator();

            // Act
            var result = mathOperator.Multiply(4, 3);
            // Assert
            Assert.NotEqual(10, result);
        }

        [Fact]
        public void DivideNumbersTest_Success()
        {
            // Arrange
            var mathOperator = new MathOperator();

            // Act
            var result = mathOperator.Divide(4, 2);
            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void DivideNumbersTest_Fail()
        {
            // Arrange
            var mathOperator = new MathOperator();

            // Act
            var result = mathOperator.Divide(6, 2);
            // Assert
            Assert.NotEqual(2, result);
        }

        // [Fact]
        // public void SquareRootNumberTest_Success()
        // {
        //     // Arrange
        //     var mathOperator = new MathOperator
        //     {
        //         num1 = "16"
        //     };
            
        //     // Act
        //     mathOperator.SquareRootNumber();
            
        //     // Assert
        //     Assert.Equal("4", mathOperator.finalresult);
        // }

        // [Fact]
        // public void SquareRootNumberTest_Fail()
        // {
        //     // Arrange
        //     var mathOperator = new MathOperator
        //     {
        //         num1 = "16"
        //     };
            
        //     // Act
        //     mathOperator.SquareRootNumber();
            
        //     // Assert
        //     Assert.Equal("4", mathOperator.finalresult);
        // }

        // [Fact]
        // public void ModulusNumbersTest_Success()
        // {
        //     // Arrange
        //     var mathOperator = new MathOperator
        //     {
        //         num1 = "5",
        //         num2 = "2"
        //     };
            
        //     // Act
        //     mathOperator.ModulusNumbers();
            
        //     // Assert
        //     Assert.Equal("1", mathOperator.finalresult);
        // }

        // [Fact]
        // public void ModulusNumbersTest_Fail()
        // {
        //     // Arrange
        //     var mathOperator = new MathOperator
        //     {
        //         num1 = "7",
        //         num2 = "3"
        //     };
            
        //     // Act
        //     mathOperator.ModulusNumbers();
            
        //     // Assert
        //     Assert.NotEqual("2", mathOperator.finalresult);
        // }

        // [Fact]
        // public void PowerNumbersTest_Success()
        // {
        //     // Arrange
        //     var mathOperator = new MathOperator
        //     {
        //         num1 = "2",
        //         num2 = "3"
        //     };
            
        //     // Act
        //     mathOperator.PowerNumbers();
            
        //     // Assert
        //     Assert.Equal("8", mathOperator.finalresult);
        // }

        // [Fact]
        // public void PowerNumbersTest_Fail()
        // {
        //     // Arrange
        //     var mathOperator = new MathOperator
        //     {
        //         num1 = "2",
        //         num2 = "4"
        //     };
            
        //     // Act
        //     mathOperator.PowerNumbers();
            
        //     // Assert
        //     Assert.NotEqual("8", mathOperator.finalresult);
        // }
    }
}