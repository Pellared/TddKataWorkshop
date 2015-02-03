using Xunit;

namespace Game
{

    public class GameTests
    {

        [Theory]
        [InlineDataAttribute(1, "I")]
        [InlineDataAttribute(5, "V")]
        [InlineDataAttribute(10, "X")]
        [InlineDataAttribute(50, "L")]
        [InlineDataAttribute(100, "C")]
        [InlineDataAttribute(500, "D")]
        [InlineDataAttribute(1000, "M")]
        public void Should_Convert_BasicNumber_to_Roman(int input, string output)
        {
            var game = new Game();
            string result = game.ConvertToRomanNumber(input);
            Assert.Equal(result, output);
        }
    }
}