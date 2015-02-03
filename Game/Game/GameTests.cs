using System.Collections.Generic;
using System.Linq.Expressions;
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
        public void check_result_no_strice_no_spare()
        {
            var game = new Game();
            int result = game.Result(new []{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1});
            Assert.Equal(20, result);
        }

      
    }
}