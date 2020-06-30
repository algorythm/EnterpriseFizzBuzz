using FizzBuzz.Library.Parser;
using FluentAssertions;
using Xunit;

namespace FizzBuzz.Library.UnitTests.Parser
{
    public class IntegerParserTests
    {
        private readonly IIntegerParser _parser;

        public IntegerParserTests()
        {
            _parser = new IntegerParser();
        }

        [Theory]
        [InlineData("1337")]
        [InlineData("0")]
        [InlineData("-7")]
        [InlineData("1")]
        [InlineData("-999")]
        [InlineData("  3  ")]
        public void WhenValuesAreIntegers_ShouldReturnTrue(string value)
        {
            var result = _parser.IsInteger(value);
            
            result.Should().Be(true);
        }

        [Theory]
        [InlineData("leet")]
        public void WhenValuesAreNotIntegers_ShouldReturnFalse(string value)
        {
            var result = _parser.IsInteger(value);

            result.Should().Be(false);
        }
    }
}
