using Xunit;
using System.Linq;

namespace Game
{
    public class GameTests
    {
        [Fact]
        public void Add_values_returns_the_sum()
        {
            var game = new Game();
            int result = game.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Throw_is_a_strike()
        {
            var _throw = new Throw();
            Assert.Equal(_throw.Scores, new int[] {10,0,0});
        }

    }
}