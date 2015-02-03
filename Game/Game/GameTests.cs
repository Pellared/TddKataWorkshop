using Xunit;
using System.Linq;

namespace Game
{
    public class GameTests
    {
        [Fact]
        public void Throw_is_a_strike()
        {
            var game = new Game();
            game.Throws = new[] { 10, 0, 0 };
            Assert.Equal(game.IsStrike(), true);
        }

        [Fact]
        public void TestSpare()
        {
            var game = new Game();
            game.Throws = new[] { 4, 6, 0 };
            Assert.Equal(game.IsSpare(), true);
        }

        [Fact]
        public void TestIsExtraThrow()
        {
            var game = new Game();
            game.Throws = new[] { 6, 4, 0 };
            Assert.Equal(game.IsExtraThrow(), true);
        }

        [Fact]
        public void TestScore()
        {
            var game = new Game();
            game.Throws = new[] { 6, 4, 5 };
            Assert.Equal(game.Score(), 15);
        }

    }
}