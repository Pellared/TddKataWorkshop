using System.Collections.Generic;
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
        public void with_no_spare()
        {
            var game = new Game();
            int result = game.Result(new List<Frame>(){new Frame(1,4), new Frame(3,5)});
            Assert.Equal(13, result);
        }


        [Fact]
        public void with_one_spare()
        {
            var game = new Game();
            int result = game.Result(new List<Frame>() { new Frame(1, 9), new Frame(3, 5) });
            Assert.Equal(21, result);
        }
    }

    
}