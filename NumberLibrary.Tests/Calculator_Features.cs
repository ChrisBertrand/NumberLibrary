using Xunit;

namespace NumberLibrary.Tests
{
    public class Calculator_Features
    {
        private readonly Calculator _calculator;

        public Calculator_Features()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void Prime_ReturnFalse_GivenValueLessThan2(int value)
        {
            var result = _calculator.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");
        }

        [Fact]
        public void Add_Return2_Given1Plus1()
        {
            var result = _calculator.add(1, 1);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Square_Return25_Given5()
        {
            var result = _calculator.squared(5);
            Assert.Equal(25, result);
        }

        [Theory]
        [InlineData(25)]
        [InlineData(64)]
        [InlineData(81)]
        public void IsSquare_ReturnsTrue_GivenSqauredNums(int value)
        {
            var result = _calculator.isSquareNumber(value);
            Assert.True(result, $"{value} should be a square number");
        }
    }
}
