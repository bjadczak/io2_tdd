using ClassLibrary;

namespace TestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("", 0)]
        public void WhenEmptyStringProvided_ReturnZero(string input, int expected)
        {
            var calc = new Calculator();

            Assert.Equal(0, calc.Add(""));

        }
    }
}