using WebCalculatorLib;

namespace WebCalculatorTests
{
    public class MathOperatorTest
    {
        [Fact]
        public void AddNumbersTest()
        {
            var mathOperator = new MathOperator
            {
                num1 = "1",
                num2 = "2"
            };
            mathOperator.AddNumbers();
            Assert.Equal("3", mathOperator.finalresult);
        }
    }
}