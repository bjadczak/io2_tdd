using ClassLibrary;

namespace TestProject
{
    public class CalcTests
    {

        [Fact]
        public void WhenEmptyStringProvided_ReturnZero()
        {
            var calc = new Calculator();

            Assert.Equal(0, calc.Add(""));

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
        [InlineData("-1", -1)]
        [InlineData("0", 0)]
        [InlineData("23423423", 23423423)]
        [InlineData("-23423423", -23423423)]
        public void WhenOneNumberProvided_ReturnNumber(string number, int expected)
        {
            var calc = new Calculator();

            Assert.Equal(expected, calc.Add(number));

        }
    }
}