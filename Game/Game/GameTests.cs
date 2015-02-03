using Xunit;

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
        public void CheckThrow()
        {
                 
        }
    }
}