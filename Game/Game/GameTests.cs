using Xunit;

namespace Game
{
    public class GameTests
    {
        [Theory]
        [InlineDataAttribute(1,"I")]
        [InlineDataAttribute(5,"V")]
        [InlineDataAttribute(10,"X")]
        [InlineDataAttribute(50,"L")]
        [InlineDataAttribute(100,"C")]
        [InlineDataAttribute(500,"D")]
        [InlineDataAttribute(1000,"M")]
        public void Should_Convert_Basic_Roman_Numbers_From_Arabic_Number(int input, string output)
        {
            var game = new Game();
            string result = game.ConvertToRomanNumber(input);
            Assert.Equal(output, result);
        }

        [Fact]
        public void ConvertFourToRomanNumber()
        {
            var game = new Game();
            string result = game.ConvertToRomanNumber(4);
            Assert.Equal(result, "IV");
        }
        [Fact]
        public void Convert18ToRomanNumber()
        {
            var game = new Game();
            string result = game.ConvertToRomanNumber(18);
            Assert.Equal(result, "XVIII");
        }
        [Fact]
        public void Convert400ToRomanNumber()
        {
            var game = new Game();
            string result = game.ConvertToRomanNumber(400);
            Assert.Equal(result, "CD");
        }
        [Fact]
        public void Convert494ToRomanNumber()
        {
            var game = new Game();
            string result = game.ConvertToRomanNumber(494);
            Assert.Equal(result, "CDXCIV");
        }
    }
}