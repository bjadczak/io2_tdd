using ClassLibrary;

namespace TestProject
{
    public class CalcTests
    {
        private readonly Calculator _calculator;

        public CalcTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void WhenEmptyStringProvided_ReturnZero()
        {
            Assert.Equal(0, _calculator.Add(""));

        }
        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        [InlineData("4", 4)]
        [InlineData("5", 5)]
        [InlineData("6", 6)]
        [InlineData("7", 7)]
        [InlineData("8", 8)]
        [InlineData("9", 9)]
        [InlineData("0", 0)]
        public void WhenOneNumberProvided_ReturnNumber(string number, int expected)
        {

            Assert.Equal(expected, _calculator.Add(number));

        }
        [Theory]
        [InlineData("1,1", 2)]
        [InlineData("1,2", 3)]
        [InlineData("2,1", 3)]
        [InlineData("200,1", 201)]
        [InlineData("0,0", 0)]
        public void WhenTwoNumbersSeparetaedByComaPrivided_ReturnSum(string number, int expected)
        {

            Assert.Equal(expected, _calculator.Add(number));

        }
        [Theory]
        [InlineData("1\n1", 2)]
        [InlineData("1\n2", 3)]
        [InlineData("2\n1", 3)]
        [InlineData("200\n1", 201)]
        [InlineData("0\n0", 0)]
        public void WhenTwoNumbersSeparetaedByNewLinePrivided_ReturnSum(string number, int expected)
        {

            Assert.Equal(expected, _calculator.Add(number));

        }
        [Theory]
        [InlineData("1\n1,3", 5)]
        [InlineData("1\n2,1", 4)]
        [InlineData("2,1\n0", 3)]
        [InlineData("200\n1,100", 301)]
        [InlineData("200,1,100", 301)]
        [InlineData("200,1\n100", 301)]
        [InlineData("200\n1\n100", 301)]
        [InlineData("0\n0\n0", 0)]
        [InlineData("0,0,0", 0)]
        [InlineData("0,0\n0", 0)]
        [InlineData("0\n0,0", 0)]
        public void WhenThreeNumbersSeparetaedByNewLineOrComaPrivided_ReturnSum(string number, int expected)
        {

            Assert.Equal(expected, _calculator.Add(number));

        }
        [Theory]
        [InlineData("-1")]
        public void WhenNegativeNumberProvided_ExpectException(string number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.Add(number));
        }
        [Theory]
        [InlineData("23423423", 0)]
        [InlineData("200\n1\n1001", 201)]
        [InlineData("1\n1001", 1)]
        public void WhenNumberGreaterThan1000_Ignore(string number, int expected)
        {
            Assert.Equal(expected, _calculator.Add(number));
        }
    }
}